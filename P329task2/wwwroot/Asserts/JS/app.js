let slider = document.querySelector('.slider')

document.querySelectorAll('.uls ul li').forEach(function(indicator, index) {
    indicator.addEventListener('click', function() {
        document.querySelector('.uls .selected').classList.remove('selected')
        indicator.classList.add('selected')
        slider.style.transform = `translate(${index * -25}%)`
    })
 
})

