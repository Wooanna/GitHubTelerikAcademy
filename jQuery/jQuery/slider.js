/// <reference path="libs/jquery.min.js" />
var $body = $('body');
var urls = [
    'http://www.webdesignmash.com/trial/wp-content/uploads/2010/09/colourful-autumn-photography-04.jpg',
    'http://www.thinkstockphotos.co.uk/CMS/StaticContent/WhyThinkstockImages/Best_Images.jpg',
    'http://api.ning.com/files/omkt7cwbhXLXFLGajzJMT-B47awZg3qsY00PtxaTIq0klG3K62tblhVj6t1VFQdKjm3N49bybyLp8xCzp*kZUvbZsQEza76e/LOOKAROUND.jpg',
     'http://blog.gettyimages.com/wp-content/uploads/2013/04/The-Renewables-Project_London-Exhibit_April-2013_Toby-Smith_Reportage-by-Getty-Images.jpg',
     'http://blog.karachicorner.com/wp-content/uploads/2012/07/timeline-covers/fb-cover-image-3.jpg',
     'http://blog.gettyimages.com/wp-content/uploads/2013/03/Breed_Henrik-Sorensen_Stone_145565784-628x471.jpg',
     'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSTHgVdRkMW3NHyf1izqyOh5Vv861hxNx-pjnnpHWHfyKwo5N3u',
     'http://crispyclicks.com/wp-content/uploads/2013/03/weird-images-weird-pictures-floating-in-the-air-4.jpg'
];


var effectBefore = function (el, speed, callback) {
    el.animate({ height: 0 }, speed, callback);
};

var effectAfter = function (el, speed) {
    el.animate({ height: 100 }, speed);
};

$('<div>').css('background-color', '#333')
    .attr('id', 'sl-container')
.appendTo($body);

$('<img>').attr('src', 'images/right_arrow_off.png')
    .attr('id', 'right-arrow')
.appendTo($('#sl-container'))

$('<div>').attr('id', 'small-img-container')
.appendTo($('#sl-container'));

$('<input>').attr('type', 'button')
    .attr('id', 'slideshow-button')
    .val('Slideshow')
    .appendTo('#sl-container');

for (var i = 0; i < urls.length; i++) {
    $('<img>').attr('src', urls[i])
        .addClass('thumbnail')
        .attr('id', '' + (i+1))
        .css('height', 80)
        .css('margin', 20)
    .appendTo($('#small-img-container'));
}

$('<img>').attr('src', 'images/left_arrow_off.png')
     .attr('id', 'left-arrow')
.prependTo($('#sl-container'));


$('#left-arrow, #right-arrow').on('mouseout', function () {
    $(this).css('-webkit-filter', 'sepia(0%)');
})
$('#left-arrow, #right-arrow').on('mouseover', function () {
    $(this).css('-webkit-filter', 'sepia(100%)');
})

$('img.thumbnail').on('mouseover', function () {
    $(this).css('box-shadow', '0px 0px 20px #888');
})

$('img.thumbnail').on('mouseout', function () {
    $(this).css('box-shadow', 'none');
})

$('img.thumbnail').on('click', function () {

    if ($('.current')) {
        $('.current').remove();
    }
    var currentUrl = $(this).attr('src');

    $('<img>').attr('src', currentUrl)
        .addClass('current')
        .css('height', '400px')
        .css('position', 'absolute')
        .css('margin', 'auto')
        .css('left', 0)
        .css('top', 0)
        .css('bottom', '120px')
        .css('right', 0)
        .appendTo($('#sl-container'));

    selectedImg = $(this);
})



$('#slideshow-button').on('click', function () {
    if ($('.current')) {
        $('.current').remove();
    }
    for (var i = 0; i < urls.length; i++) {
        $('<img>').attr('src', urls[i])
             .addClass('current')
            .attr('id', 'img' +  i)
             
            .appendTo($('#sl-container')).hide();
    }
    for (var i = 0; i < urls.length; i++) {
        $('#img' + i).delay(4000 * i).fadeIn(1500).delay(1000).fadeOut(1500)
       
    }
})

$('#right-arrow').on('click', function () {
   
    var currentUrl = $('.current').attr('src');
    var index = urls.indexOf(currentUrl)
    if (index == urls.length - 1) {
        index = -1;
    }
    if ($('.current')) {
        $('.current').remove();
    }
        
    $('<img>').attr('src', urls[index + 1])
        .addClass('current')
        .appendTo($('#sl-container'));
})

$('#left-arrow').on('click', function () {

    var currentUrl = $('.current').attr('src');
    var index = urls.indexOf(currentUrl)
    if (index == 0) {
        index = urls.length;
    }
    if ($('.current')) {
        $('.current').remove();
    }

    $('<img>').attr('src', urls[index - 1])
        .addClass('current')
        .appendTo($('#sl-container'));
})


