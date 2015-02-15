Polymer('projects-api', {
    created: function () {
        this.projects = [];
    },
    projectsLoaded: function () {
        this.projects = this.$.ajax.response.slice(0);
    },
});