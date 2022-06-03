const Joi = require('joi');
const express = require('express');
const { countReset } = require('console');
const app = express();

app.use(express.json()); //ading a piece of middleware

const events = [
  {id: 1, name: 'Hayleys Graduation', date: "May 13th"},
  {id: 2, name: 'Rachels Wedding', date: "September 24th"},
  {id: 3, name: 'Hunters Baptism', date: "June 25th"}
]

app.get('/api/events', (req, res) => {
  res.send(events);
});

app.post('/api/events', (req, res) => {
  const { error } = validateEvent(req.body);
  //if invalid 400 error
  if(error) {
    res.status(400).send(error.details[0].message);
    return;
  };

  const event = {
    id: events.length + 1,
    name: req.body.name,
    date: req.body.date
  };
  events.push(event);
  res.send(event);
});

app.put('/api/events/:id', (req,res) => {
  //look up the course
  const event = events.find(c => c.id === parseInt(req.params.id));
  if(!event) {
  return res.status(404).send('The course was not found with that id');
  };

  //validate course
  const { error } = validateEvent(req.body);
  //if invalid 400 error
  if(error) {
    res.status(400).send(error.details[0].message);
    return;
  };

  //update course
  event.name = req.body.name;
  event.date = req.body.date;
  //return updated course
  res.send(event);
}); //this code does not work... no errors either

app.delete('/api/events/:id', (req, res) => {
  //look up the courese
  //return 404 if error
  const event = events.find(c => c.id === parseInt(req.params.id));
  if(!event) res.status(404).send('The event was not found with that id');

  //delete
  const index = events.indexOf(event);
  events.splice(index, 1);

  res.send(event);

  //return the same coures
})


// /api/courses/1 
app.get('/api/events/:id', (req, res)=> {
 const event = events.find(c => c.id === parseInt(req.params.id));
 if(!event) res.status(404).send('The course was not found with that id');//404 error status; object not found
 res.send(event);
}) //id is a parameter here


//environment variable called PORT
const port = process.env.PORT || 3000;
app.listen(port, ()=> console.log(`Listening on port ${port}...`));


function validateEvent(course) {
  const schema = Joi.object({
    name: Joi.string().min(3).required(),
    date: Joi.string().min(3).required()         
  });
  
 return schema.validate(course);
}