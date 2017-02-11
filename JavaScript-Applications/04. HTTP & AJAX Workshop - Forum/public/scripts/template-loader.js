// import { Handlebars } from '../node_modules/handlebars/dist/handlebars.js';

const templateLoader = (() => {
    const templatesCache = {};

    function get(templateName) {
        return new Promise((resolve, reject) => {
            if (templatesCache[templateName]) {
                resolve(templatesCache[templateName]);
            } else {
                $.get(`/scripts/templates/${templateName}.handlebars`)
                    .done((data) => {
                        let compiledTemplate = Handlebars.compile(data);
                        templatesCache[templateName] = compiledTemplate;
                        resolve(compiledTemplate);
                    }).fail(reject);          
            }
        })
    }

    return {
         get 
        }
})();

export { templateLoader };