const Joi = require('joi');
const express = require('express');
const { countReset } = require('console');
const app = express();

app.use(express.json()); //ading a piece of middleware

const courses = [
  {id: 1, name: 'History'},
  {id: 2, name: 'Math'},
  {id: 3, name: 'Science'}
]

app.get('/', (req, res)=> {
  res.send('Hello World!!!');
});

app.get('/api/courses', (req, res) => {
  res.send([1, 2, 3]);
});

app.post('/api/courses', (req, res) => {
  const { error } = validateCourse(req.body);
  //if invalid 400 error
  if(error) {
    res.status(400).send(error.details[0].message);
    return;
  };

  const course = {
    id: courses.length + 1,
    name: req.body.name
  };
  courses.push(course);
  res.send(course);
});

app.put('/api/courses/:id', (req,res) => {
  //look up the course
  const course = courses.find(c => c.id === parseInt(req.params.id));
  if(!course) {
  return res.status(404).send('The course was not found with that id');
  };

  //validate course
  const { error } = validateCourse(req.body);
  //if invalid 400 error
  if(error) {
    res.status(400).send(error.details[0].message);
    return;
  };

  //update course
  course.name = req.body.name;
  //return updated course
  res.send(course);
}); //this code does not work... no errors either

app.delete('/api/courses/:id', (req, res) => {
  //look up the courese
  //return 404 if error
  const course = courses.find(c => c.id === parseInt(req.params.id));
  if(!course) res.status(404).send('The course was not found with that id');

  //delete
  const index = courses.indexOf(course);
  courses.splice(index, 1);

  res.send(course);

  //return the same coures
})




// /api/courses/1 
app.get('/api/courses/:id', (req, res)=> {
 const course = courses.find(c => c.id === parseInt(req.params.id));
 if(!course) res.status(404).send('The course was not found with that id');//404 error status; object not found
 res.send(course);
}) //id is a parameter here


//environment variable called PORT
const port = process.env.PORT || 3000;
app.listen(port, ()=> console.log(`Listening on port ${port}...`));


function validateCourse(course) {
  const schema = Joi.object({
    name: Joi.string().min(3).required()
  });
  
 return schema.validate(course);
}
