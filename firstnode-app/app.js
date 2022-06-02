
//function sayHello(name)
//{
 //   console.log('Hello '+ name); //global object; can be accessed anywhere
//}
//sayHello('Hayley');

//setTimeout() //calls a delay by seconds
//clearTimeout()

//setInterval() //calls a function repeatedly
//clearInterval() //stops the repeated calls

//global is the way to call something in Node
//you do not need to use the global call in ode; it is implied
//window is how you would do it in the browser if you did not use node


//CONSTANT IN NODE
//const logger = require('./logger.js'); //returns the exported object from the target module
    //const makes it so that you can't override the value of log
//logger.log('message');

//PARSE IN NODE
//const path = require('path');
//var pathObj = path.parse(__filename);
//console.log(pathObj);


//SHOW THE DIRECTORY OF THE FOLDER YOU ARE IN 
//const fs = require('fs');
//const files = fs.readdir('./',function(err, files)
//{
  //  if (err) console.log('Error', err);
    //else console.log('Result', files)
//});
//console.log(files);


//EVENT EMITTER
/*const EventEmitter = require('events'); //EventEmitter is a class; that is why two capitals

const Logger = require('./logger');
const logger = new Logger();

logger.on('messageLogged', (arg)=> //added a parameter with arg
{
    console.log('Listener called!', arg);
});

logger.log('message');*/

const http = require('http');

const server = http.createServer((req,res)=>{
  if(req.url === '/') {
    res.write('Hello World');
    res.end();
  }

  if(req.url === '/api/courses') {
      res.write(JSON.stringify([1, 2, 3]))
      res.end();
  }
});

server.listen(3000); //this is a port (3000)

console.log('Listening on port 3000...')


