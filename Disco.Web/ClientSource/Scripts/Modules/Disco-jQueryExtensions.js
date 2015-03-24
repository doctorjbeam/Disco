﻿/// <reference path="../../Core/jquery-1.7.1.js" />
(function ($) {

    var checkboxBulkSelectMethods = {
        init: function (options) {

            options = $.extend({ parentSelector: 'tr' }, options);

            return this.each(function () {
                var $this = $(this);
                $this.data('checkboxBulkSelect_parentSelector', options.parentSelector);
                var $checkboxes = $this.closest(options.parentSelector).find('input[type="checkbox"]');

                if ($checkboxes.length > 0) {
                    var $selectAll, $selectNone;

                    function selectAll() {
                        $checkboxes.prop('checked', true);
                        update();
                        return false;
                    }
                    function selectNone() {
                        $checkboxes.prop('checked', false);
                        update();
                        return false;
                    }
                    function update() {
                        checkboxBulkSelectMethods.update.apply($this, [$checkboxes, options.parentSelector, $selectAll, $selectNone]);
                    }

                    $selectAll = $('<a>').addClass('selectAll').attr('href', '#').text('ALL').click(selectAll);
                    $selectNone = $('<a>').addClass('selectNone').attr('href', '#').text('NONE').click(selectNone);

                    $this.append($('<span>').text('Select: '), $selectAll, $('<span>').text(' | '), $selectNone);
                    $checkboxes.click(update);

                    update();
                }
            });
        },
        update: function ($checkboxes, parentSelector, $selectAll, $selectNone) {
            return this.each(function () {
                $this = $(this);
                if (!parentSelector)
                    parentSelector = $this.data('checkboxBulkSelect_parentSelector');
                if (!$checkboxes)
                    $checkboxes = $this.closest(parentSelector).find('input[type="checkbox"]');
                if (!$selectAll)
                    $selectAll = $this.find('a.selectAll').first();
                if (!$selectNone)
                    $selectNone = $this.find('a.selectNone').first();
                var $selectedCheckboxes = $checkboxes.filter(':checked');

                if ($checkboxes.length == $selectedCheckboxes.length) {
                    // All Selected
                    $selectAll.prop('disabled', true);
                    $selectNone.prop('disabled', false);
                } else {
                    if ($selectedCheckboxes.length == 0) {
                        // None Selected
                        $selectNone.prop('disabled', true);
                        $selectAll.prop('disabled', false);
                    } else {
                        // Some Selected
                        $selectAll.prop('disabled', false);
                        $selectNone.prop('disabled', false);
                    }
                }
            });
        }
    }

    $.fn.checkboxBulkSelect = function (method) {
        if (checkboxBulkSelectMethods[method]) {
            return checkboxBulkSelectMethods[method].apply(this, Array.prototype.slice(arguments, 1));
        } else if (typeof method === 'object' || !method) {
            return checkboxBulkSelectMethods.init.apply(this, arguments);
        } else {
            $.error('Method ' + method + ' does not exist on jQuery.checkboxBulkSelect');
        }
    }
})(jQuery);
