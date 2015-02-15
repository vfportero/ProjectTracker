var template = document.querySelector('#t');
var ajax, pages, scaffold;

template.pages = [
    { name: 'Tarea activa', hash: 'current-track', icon: 'query-builder', url: '/views/current-track.html' },
    { name: 'Proyectos', hash: 'projects', icon: 'work', url: '/views/projects.html' },
    { name: 'Estadísticas', hash: 'stats', icon: 'trending-up', url: '/views/stats.html' },
];

template.addEventListener('template-bound', function (e) {
    // Use URL hash for initial route. Otherwise, use the first page.
    this.route = this.route || "current-track";
    scaffold = document.querySelector('#scaffold');
    ajax = document.querySelector('#ajax');
    pages = document.querySelector('#pages');
});

template.menuItemSelected = function (e, detail, sender) {
    if (detail.isSelected) {

        // Need to wait one rAF so <core-ajax> has it's URL set.
        this.async(function () {
            scaffold.closeDrawer();
        });

    }
};

template.preventDefault = function (e) {
    e.preventDefault();
};

template.onResponse = function (e, detail, sender) {
    var html = detail.response.querySelector("body").innerHTML;

    this.injectBoundHTML(html, pages.selectedItem.firstElementChild);
    Polymer.import([ajax.url], function () {

    });
};