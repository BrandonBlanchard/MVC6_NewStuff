/// <binding Clean='clean' ProjectOpened='watch:less' />
"use strict";

//
var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    less = require("gulp-less"),
    path = require("path"),
    watch = require("gulp-watch"),
    batch = require("gulp-batch");

var paths = {
    webroot: "./wwwroot/"
};

paths.js = paths.webroot + "js/**/*.js";
paths.minJs = paths.webroot + "js/**/*.min.js";
paths.less = paths.webroot + "less/**/*.less";
paths.css = paths.webroot + "css/**/*.css";
paths.cssDest = paths.webroot + "css";
paths.minCss = paths.webroot + "css/**/*.min.css";
paths.concatJsDest = paths.webroot + "js/site.min.js";
paths.concatCssDest = paths.webroot + "css/site.min.css",

gulp.task("clean:js", function (cb) {
    rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);

gulp.task("min:js", function () {
    return gulp.src([paths.js, "!" + paths.minJs], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    return gulp.src([paths.css, "!" + paths.minCss])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("transpile:less", function() {
    return gulp.src(paths.less)
               .pipe(less({ paths: [path.join(__dirname, 'less', 'includes')] }))
               .pipe(gulp.dest(paths.cssDest));
});

gulp.task("watch:less", function () {
    watch(paths.less, batch(function (events, done) {
        gulp.start("less", done);
    }))
});

gulp.task("min", ["min:js", "min:css"]);
gulp.task("less", ["transpile:less", "min:css"]);
