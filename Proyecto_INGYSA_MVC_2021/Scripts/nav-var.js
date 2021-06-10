$(document).ready(function ($)
{
    var menuBtn = $('.menu-icon'),
        menu = $('.nav .nav-bar');

    menuBtn.click(function() 
    {
        if( menu.hasClass('show')) 
            menu.removeClass('show');
        else
            menu.addClass('show')
    })
})