'use strict';

class listNode {
    constructor(value) {
        this.value = value;
        this.next = null;
    }
}

class LinkedList {
    constructor() {
        this._length = 0;
        this.head = null;
    }

    append(...elements) {
        var listLen = this.length,
            node = new listNode(elements[0]),
            prevNode;

        if (listLen) {
            this.lastNode.next = node;
        } else {
            this.head = node;
        }

        this._length += 1;
        prevNode = node;
        
        for(let i = 1, len = elements.length; i < len; i += 1) {
            node = new listNode(elements[i]);
            prevNode.next = node;
            prevNode = node;
            this._length += 1;
        }

        return this;
    }

    prepend(...elements) {
        var listLen = this.length,
            node = new listNode(elements[0]),
            headNode,
            prevNode;
        
        if (listLen) {
            headNode = this.head;
        }

        this.head = node;
        prevNode = node;
        this._length += 1;

        for(let i = 1, len = elements.length; i < len; i += 1) {
            node = new listNode(elements[i]);
            prevNode.next = node;
            prevNode = node;
            this._length += 1;
        }

        prevNode.next = headNode;

        return this;
    }

    insert(...args) {
        var index =  args.shift(0),
            node = this.head,
            counter = 0,
            prevNode,
            nextNode;
        
        if (index === 0) {
            return this.prepend(...args);
        }

        while (node !== null) {
            if (counter === index - 1) {
                prevNode = node;
                nextNode = node.next;
                break;
            }

            node = node.next;
            counter += 1;
        }

        for(let i = 0, len = args.length; i < len; i += 1) {
            node = new listNode(args[i]);
            prevNode.next = node;
            prevNode = node;
            this._length += 1;
        }

        prevNode.next = nextNode;

        return this;
    }

    removeAt(index) {
        var node = this.head,
            nextNode = node.next,
            counter = 0,
            prevNode;

        while (node !== null) {
            if (counter === index) {
                if (prevNode) {
                   prevNode.next = nextNode;
                } else {
                    this.head = nextNode;
                }

                this._length -= 1;
                break;
            }

            prevNode = node;
            node = node.next;
            nextNode = node.next;
            counter += 1;
        }

        return node.value;
    }

    at(index, value) {
        var node = this.head,
            counter = 0;

        while (node !== null) {
            if (counter === index) {
                if (typeof value === 'undefined') {
                    return node.value;
                } else {
                    node.value = value;
                    return this;
                }
            }

            node = node.next;
            counter += 1;
        }

        
    }

    toArray() {
        var arr = [],
            node = this.head;
        
        while (node !== null) {
            arr.push(node.value);
            node = node.next;
        }
        
        return arr;
    }

    [Symbol.iterator]() {
        var node = this.head;

        return {
            next: () => ({ value: node.value, done: !(node.next === null),
            node: node.next })
        };
    }

    get first() {
        return this.head.value;
    }

    get last() {
        var node = this.head,
            lastValue;
            
        while (node !== null) {
            lastValue = node.value;
            node = node.next;
        }

        return lastValue;
    }

    get lastNode() {
        var node = this.head,
            lastNode;
            
        while (node !== null) {
            lastNode = node;
            node = node.next;
        }

        return lastNode;
    }

    get length() {
        return this._length;
    }

    toString() {
        var result = '',
            counter = 0,
            len = this.length,
            node = this.head;
        
        while (node !== null) {
            result += node.value;
            counter++;
            if (counter < len) {
                result += ' -> ';
            }

            node = node.next;
        }

        return result;
    }
}

module.exports = LinkedList;