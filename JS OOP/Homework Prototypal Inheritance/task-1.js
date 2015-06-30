/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors   DONE
 * method init() that gets the domElement type  DONE
 * i.e. `Object.create(domElement).init('div')
 * property type that is the type of the domElement   DONE 
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string DONE
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string   DONE 
 * sets the content of the element
 * works only if there are no children
 * property attributes   DONE 
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children   DONE 
 * each child is a domElement or a string
 * property parent   DONE 
 * parent is a domElement
 * method appendChild(domElement / string)   DONE 
 * appends to the end of children list
 * method addAttribute(name, value)   DONE 
 * throw Error if type is not valid
 * method removeAttribute(attribute)   DONE 
 * throw Error if attribute does not exist in the domElement
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

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/
function solve() {
    var domElement = (function() {
        var pavel = 5;
        var domElement = {
            init: function(type) {
                this.type = type;
                this.content = '';
                this.attributes = [];
                this.children = [];
                this.parent;
                return this;
            },
            appendChild: function(child) {
                if (typeof child === 'object') {
                    child.parent = this;
                }
                this.children.push(child);
                return this;
            },
            addAttribute: function(name, value) {
                if (!isValidAttribute(name)) {
                    throw new Error('Invalid string for attribute name');
                }
                this.attributes[name] = value;
                return this;
            },
            removeAttribute: function(attributeName) {
                if (!this.attributes[attributeName]) {
                    throw new Error('An attribute with this name does not exists!');
                }
                delete this.attributes[attributeName];
                return this;
            },
            get innerHTML() {
                // <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
                var openArrow = '<',
                    closeArrow = '>',
                    result = '',
                    i,
                    len;

                result += openArrow + this.type;
                result += getAttributes(this.attributes);
                result += closeArrow;
                if(this.children.length > 0){
                    for (i = 0, len = this.children.length; i < len; i += 1) {
                        var child = this.children[i];
                        if(typeof child === 'object'){
                            result += child.innerHTML;
                        }else{
                            result += child;
                        }
                    }
                }else{
                    result += this.content || '';
                }    
                
                result += openArrow + '/' + this.type + closeArrow;

                return result;
            }
        };
        Object.defineProperty(domElement, 'type', {
            get: function() {
                return this._type;
            },
            set: function(value) {
                if (!isValidType(value)) {
                    throw new Error('Invalid string for type');
                }
                this._type = value;
                return this;
            }
        });
        Object.defineProperty(domElement, 'content', {
            get: function() {
                return this._content;
            },
            set: function(value) {
                this._content = value;
                return this;
            }
        });

        function getAttributes(attributes) {
            var result = '',
                keys = [],
                i,
                len;
            keys = sortAttributesNames(attributes);
            for (i = 0, len = keys.length; i < len; i += 1) {
                result += ' ' + keys[i] + '="' + attributes[keys[i]] + '"';
            }

            return result;
        }

        function sortAttributesNames(attributes) {
            var keys = [],
                attr;
            for (attr in attributes) {
                keys.push(attr);
            }
            keys.sort();
            return keys;
        }

        function isValidType(type) {
            var pattern = /^[A-z0-9]+$/;
            if (typeof type !== 'string' || type === '' || pattern.test(type) === false) {
                return false;
            }
            return true;
        }

        function isValidAttribute(attribute) {
            var pattern = /^[A-z0-9\-]+$/;
            if (typeof attribute !== 'string' || attribute === '' || pattern.test(attribute) === false) {
                return false;
            }
            return true;
        }
        return domElement;
    }());
    return domElement;
}

module.exports = solve;