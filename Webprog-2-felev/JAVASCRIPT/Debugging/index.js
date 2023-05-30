const {list, FillListWithRandomNumbers, FindMaxList} = require('./list_module.js');
FillListWithRandomNumbers(1, 1000, 20);
const max = FindMaxList();
console.log(list);
console.log(max);