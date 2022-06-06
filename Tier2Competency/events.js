const Joi = require('joi');
const express = require('express');
const { countReset } = require('console');
const app = express();

app.use(express.json()); //ading a piece of middleware

const clothes = [
  {id: 1, name: 'Green Dress', brand: "H&M", Size: "Small", price: 10.50},
  {id: 2, name: 'Flowered Top', brand: "Banana Republic", Size: "Small", price: 35.00},
  {id: 3, name: 'Navy Blue Purse', brand: "Longchamp", Size: "One Size", price: 100.00},
  {id: 4, name: 'Sandals', brand: "Birkenstock", Size: "9", price: 120.00},
]

app.get('/api/clothes', (req, res) => {
  res.send(clothes);
});

app.post('/api/clothes', (req, res) => {
  const { error } = validateClothes(req.body);
  //if invalid 400 error
  if(error) {
    res.status(400).send(error.details[0].message);
    return;
  };

  const clothing = {
    id: clothes.length + 1,
    name: req.body.name,
    brand: req.body.brand
  };
  clothes.push(clothing);
  res.send(clothing);
});

app.put('/api/clothes/:id', (req,res) => {
  //look up the clothing item
  const clothing = clothes.find(c => c.id === parseInt(req.params.id));
  if(!clothing) {
  return res.status(404).send('The item you were looking for with that id was not found');
  };

  //validate clothes
  const { error } = validateClothes(req.body);
  //if invalid 400 error
  if(error) {
    res.status(400).send(error.details[0].message);
    return;
  };

  //update course
  clothing.name = req.body.name;
  clothing.brand = req.body.brand;
  //return updated course
  res.send(clothing);
}); //this code does not work... no errors either

app.delete('/api/clothes/:id', (req, res) => {
  //look up the courese
  //return 404 if error
  const clothing = clothes.find(c => c.id === parseInt(req.params.id));
  if(!clothing) res.status(404).send('The itme was not found with that id');

  //delete
  const index = clothes.indexOf(clothing);
  clothes.splice(index, 1);

  res.send(clothing);

  //return the same coures
})

app.get('/api/clothes/:id', (req, res)=> {
 const clothing = clothes.find(c => c.id === parseInt(req.params.id));
 if(!clothing) res.status(404).send('The clothing item was not found with that id');//404 error status; object not found
 res.send(clothing);
}) //id is a parameter here


//environment variable called PORT
const port = process.env.PORT || 3000;
app.listen(port, ()=> console.log(`Listening on port ${port}...`));


function validateClothes(clothing) {
  const schema = Joi.object({
    name: Joi.string().min(3).required(),
    brand: Joi.string().min(3).required()         
  });
  
 return schema.validate(clothing);
}