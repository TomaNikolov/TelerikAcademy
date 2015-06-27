(function () {
    var browserName = navigator.appName,

        addScroll = false,
        pointX = 0,
        pointY = 0;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    document.onmousemove = mouseMove;

    if (browserName == "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);
    }

    function mouseMove(evn) {
        if (browserName == "Netscape") {
            pointX = evn.pageX - 5;
            pointY = evn.pageY;

            if (document.layers['ToolTip'].visibility == 'show') {
                PopTip();
            }
        } else {
            pointX = event.x - 5;
            pointY = event.y;
            if (document.all['ToolTip'].style.visibility == 'visible') {
                PopTip();
            }
        }
    }

    function PopTip() {
        var theLayer;

        if (browserName == "Netscape") {
            theLayer = document.layers['ToolTip'];

            if ((pointX + 120) > window.innerWidth) {
                pointX = window.innerWidth - 150;
            }

            theLayer.left = pointX + 10;
            theLayer.top = pointY + 15;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all['ToolTip'];

            if (theLayer) {
                pointX = event.x - 5;
                pointY = event.y;

                if (addScroll) {
                    pointX += document.body.scrollLeft;
                    pointY += document.body.scrollTop;
                }

                if ((pointX + 120) > document.body.clientWidth) {
                    pointX -= 150;
                }

                theLayer.style.pixelLeft = pointX + 10;
                theLayer.style.pixelTop = pY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function HideTip() {

        if (browserName == "Netscape") {
            document.layers['ToolTip'].visibility = 'hide';
        } else {
            document.all['ToolTip'].style.visibility = 'hidden';
        }
    }

    function HideMenu(menuName) {
        if (browserName == "Netscape") {
            document.layers[menuName].visibility = 'hide';
        } else {
            document.all[menuName].style.visibility = 'hidden';
        }
    }

    function ShowMenu(menuName) {
        var theLayer;
        if (browserName == "Netscape") {
            theLayer = document.layers[menuName];
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all[menuName];
            theLayer.style.visibility = 'visible';
        }
    }
})();
