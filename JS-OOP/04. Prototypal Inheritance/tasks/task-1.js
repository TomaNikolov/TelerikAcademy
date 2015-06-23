/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 co
 <html><head><meta charset="utf-8"nsole.log(root.innerHTML);
 Outputs:></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {
        var domElement = {

            init: function (type) {
                this.type = type;
                this._children = [];
                this._attr = {};

                return this;
            },
            appendChild: function (child) {
                if (typeof child !== 'string') {
                    child.parent = this;
                }

                this._children.push(child);

                return this;
            },
            addAttribute: function (name, value) {
                if (!isValidAttribute(name)) {
                    throw Error('Invalid attribute name');
                }

                this._attr[name] = value;

                return this;
            },
            removeAttribute: function (name) {
                if (!isValidAttribute(name)) {
                    throw Error('Invalid attribute name');
                }

                delete this._attr[name];

                return this;
            },
            get innerHTML() {
                return parseHtml(this);
            }
        };

        Object.defineProperty(domElement, 'type', {
            get: function () {
                return this._type;
            },
            set: function (type) {
                if (!isValidType(type)) {
                    throw Error('Invalid type');
                }
                this._type = type;

                return this;
            }
        });

        Object.defineProperty(domElement, 'content', {
            get: function () {
                return this._content;
            },
            set: function (value) {
                if (!this._children.length) {
                    this._content = value;
                }

                return this;
            }
        });

        Object.defineProperty(domElement, 'parent', {
            get: function () {
                return this._parent;
            },
            set: function (value) {
                this._parent = value;

                return this;
            }
        });

        function parseHtml(element) {
            var i,
                len,
                currentChild,
                currentAttributeKey,
                result,
                attributesKeys = sortKeys(element._attr),
                children = element._children;

            result = '<';
            result += element.type;

            for (i = 0, len = attributesKeys.length; i < len; i += 1) {
                currentAttributeKey = attributesKeys[i];
                result += ' ' + currentAttributeKey + '="' +
                    element._attr[currentAttributeKey] + '"';
            }

            result += '>';

            for (i = 0, len = children.length; i < len; i += 1) {
                currentChild = children[i];
                if (typeof currentChild === 'string') {
                    result += currentChild;
                } else {
                    result += currentChild.innerHTML;
                }
            }

            if (!children.length && element.content) {
                result += element.content;
            }

            result += '</' + element.type + '>';

            return result;
        }

        function sortKeys(obj) {
            var prop,
                result = [];

            for (prop in obj) {
                if (obj.hasOwnProperty(prop)) {
                    result.push(prop);
                }
            }

            result = result.sort(function (first, second) {
                if (first > second) {
                    return 1;
                }
                if (first < second) {
                    return -1;
                }
                // first must be equal to second
                return 0;
            });

            return result;
        }


        function isValidType(type) {
            return ((typeof type === 'string') &&
            /^[a-zA-Z0-9]+$/.test(type));
        }

        function isValidAttribute(attributeValue) {
            return (attributeValue !== '' &&
            /^[a-zA-Z0-9-]+$/.test(attributeValue));
        }

        return domElement;
    }());

    return domElement;
}

module.exports = solve;
