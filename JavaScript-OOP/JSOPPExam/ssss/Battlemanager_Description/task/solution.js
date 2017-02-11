function solve() {
    'use strict';

    const ERROR_MESSAGES = {
        INVALID_NAME_TYPE: 'Name must be string!',
        INVALID_NAME_LENGTH: 'Name must be between between 2 and 20 symbols long!',
        INVALID_NAME_SYMBOLS: 'Name can contain only latin symbols and whitespaces!',
        INVALID_MANA: 'Mana must be a positive integer number!',
        INVALID_EFFECT: 'Effect must be a function with 1 parameter!',
        INVALID_DAMAGE: 'Damage must be a positive number that is at most 100!',
        INVALID_HEALTH: 'Health must be a positive number that is at most 200!',
        INVALID_SPEED: 'Speed must be a positive number that is at most 100!',
        INVALID_COUNT: 'Count must be a positive integer number!',
        INVALID_SPELL_OBJECT: 'Passed objects must be Spell-like objects!',
        NOT_ENOUGH_MANA: 'Not enough mana!',
        TARGET_NOT_FOUND: 'Target not found!',
        INVALID_BATTLE_PARTICIPANT: 'Battle participants must be ArmyUnit-like!'
    };

    class Spell(){
        constructor(){
             
        }
        get name() {
            return this._name;
        }
        set name(name) {
            if (typeof name !== 'string') {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }
            if (name.length < 2 || name.length > 20) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_LENGTH);
            }
            if (!name.match(/[a-zA-Z]/)) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_SYMBOLS);
            }

            this._name = name;
        }

        // get manaCost() {
        //     return this._manaCost;
        // }
        // set manaCost(manaCost) {
        //     if (manaCost < 0) {
        //         throw new Error(ERROR_MESSAGES.INVALID_MANA);
        //     }

        //     this._manaCost = manaCost;
        // }

        // get effect() {
        //     return this._effect;
        // }
        // set effect(manaCost) {
        //     if (typeof effect !== 'function') {
        //         throw new Error(ERROR_MESSAGES.INVALID_EFFECT);
        //     }

        //     this._effect = effect;
        // }
    }

    class Unit {
        get name() {
            return this._name;
        }
        set name(name) {
            if (typeof name !== 'string') {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }
            if (name.length < 2 || name.length > 20) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_LENGTH);
            }
            if (!name.match(/[a-zA-Z]/)) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_SYMBOLS);
            }

            this._name = name;
        }
    }

    const getId = (function () {
        let id = 0;

        return function () {
            id += 1;
            return id;
        };
    } ());

    class ArmyUnit {
        constructor() {
            this.id = getId;
        }
        get id() {
            return this._id;
        }
        set id(id) {
            this._name = name;
        }

        get damage() {
            return this._damage;
        }
        set damage(damage) {
            if (damage < 0 && damage > 100) {
                throw new Error(ERROR_MESSAGES.INVALID_DAMAGE);
            }
            this._damage = damage;
        }

        get health() {
            return this._health;
        }
        set health(health) {
            if (health < 0 && health > 200) {
                throw new Error(ERROR_MESSAGES.INVALID_HEALTH);
            }
            this._health = health;
        }

        get count() {
            return this._count;
        }
        set count(count) {
            if (count < 0) {
                throw new Error(ERROR_MESSAGES.INVALID_COUNT);
            }
            this._count = count;
        }

        get speed() {
            return this._speed;
        }
        set speed(speed) {
            if (speed < 0 && speed > 100) {
                throw new Error(ERROR_MESSAGES.INVALID_SPEED);
            }
            this._speed = speed;
        }

    }

    // your implementation goes here

    const battlemanager = {

    };

    return battlemanager;
}

module.exports = solve;