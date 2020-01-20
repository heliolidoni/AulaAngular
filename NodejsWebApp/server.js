const express = require('express');
const routes = require('./routes');
const mongoose = require('mongoose');

const app = express();

mongoose.connect('mongodb+srv://heliolidoni:.Lidoni1991@heliotestenodejs-m40j2.mongodb.net/testeNodeJs?retryWrites=true&w=majority', {
    useNewUrlParser: true,
    useUnifiedTopology: true
});

var port = process.env.PORT || 1337;

app.use(express.json());
app.use(routes);

app.listen(port);