# Feliz internationalization sample  (i18n)

Using Feliz template, this repository shows how to implement a simple internationalization mechanism that makes parts of the application be dependent on the current users' locale.

Projects used
 - [Feliz](https://github.com/Zaid-Ajaj/Feliz)
 - [Feliz.Recoil](https://github.com/Shmew/Feliz.Recoil)

## Development

Before doing anything, start with installing npm dependencies using `npm install`.

Then to start development mode with hot module reloading, run:
```bash
npm start
```
This will start the development server after compiling the project, once it is finished, navigate to http://localhost:8080 to view the application .

To build the application and make ready for production:
```
npm run build
```
This command builds the application and puts the generated files into the `deploy` directory (can be overwritten in webpack.config.js).

### Tests

The template includes a test project that ready to go which you can either run in the browser in watch mode or run in the console using node.js and mocha. To run the tests in watch mode:
```
npm run test:live
```
This command starts a development server for the test application and makes it available at http://localhost:8085.

To run the tests using the command line and of course in your CI server, you have to use the mocha test runner which doesn't use the browser but instead runs the code using node.js:
```
npm test
```