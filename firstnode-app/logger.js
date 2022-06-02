const EventEmitter = require('events'); //EventEmitter is a class; that is why two capitals

var url ='http://mylogger.io/log' //this is made up

class Logger extends EventEmitter{ //adds the base class EventEmitter
    log(message) //defining a method in this class
    {
        //send an http request
        console.log(message);
    
        //raised an event
        this.emit('messageLogged', {id: '1', url:'http://'}); //raises an event; make noise or make something
    }
    
}

module.exports = Logger; //add a method called log; sets equal to log above


