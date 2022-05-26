const { program } = require('commander');
const chalk = require('chalk');
const fs = require('fs');

program 
    .version('0.0.1')
    .description('The main commandline interface for DOJ Patrol Form Filling')
    .option('--dept <department>', 'Department of form to fill')
    .option('--config <file>', 'Config file to use')


program.parse()
const options = program.opts();

// Check if options.config and options.dept are set
if(!options.config || !options.dept) {
    console.log(chalk.red('[ERROR]:') + ' Please specify a config file and a department to fill');
    process.exit(1);
}

// Read files and start the filling process 

try {
    const config = JSON.parse(fs.readFileSync(options.config));
    const form = require('./forms/' + options.dept.toLowerCase() + '.js');
    form.fill(config);
} catch (e) {
    console.log(chalk.red('[ERROR]:') + ' Encountered an error while running the filling process');
    console.log(chalk.red('[NodeRuntimeException]:') + ' ' + e.message);
    process.exit(1);
}
