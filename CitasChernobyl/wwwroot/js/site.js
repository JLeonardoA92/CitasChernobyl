// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function(){
    ////glish animation imagen logo



    ////animacion index login
    if ($(".boxTitular")[0]){
        // Do something if class exists
        console.log('si estoy');
        gsap.fromTo(".boxTitular", {opacity: 0, top:0}, {opacity: 1, duration: 2});
        gsap.to([$('.boxItem'), document.querySelector(".boxItem")], {opacity:1,top:0, stagger: 0.4});


    } else {
        // Do something if class does not exist
        console.log('ya no estoy');
    }

    if($('.fechaData')[0]){
       //get the current date
            const todaysDate = new Date();
            //format the date in the right format (add 1 to month because JavaScript counts from 0)
            var month = todaysDate.getMonth() + 1 ;
            var date = todaysDate.getDate();
            var year =todaysDate.getFullYear() ;

            const monthNames = ["En", "Feb", "Mar", "April", "May", "June",
            "July", "August", "Septiembre", "Oct", "Nov", "December"
            ];
         
            formatDate = month + '/' +
                        date+ '/' +
                        year;

            //set the input value
            $('.year h2').html(monthNames[todaysDate.getMonth()]) 
            $('.day h1').html(date)   
            $('.year h3').html(year)
    }
    


});