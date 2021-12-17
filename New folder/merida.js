class Enemy {
  constructor(x, y, hp = 300) {
    this.x = x
    this.y = y
    this.hp = hp
  }

  damage(amount) {
    // deduct hp by amount
    // if this.x == Archer.x, apply the 20% damage penalty and floor
    // check how many enemies are in the same x then loop through that
    // 

    if (this.x == Archer.x) {

      let reducedDamage = Math.floor(this.hp -= amount * 0.2); 
      return [reducedDamage, this.hp];
    } 
    else {
      return Math.floor(this.hp -= amount);
    }
    
    
  }

  isDead() {
    // fill this up
    // if this.hp == 0 then Archer.kills++;
  }
}

class Archer {
  constructor(arrows, field, damage = 40) {
    this.x = 0 // starts at the leftmost square
    this.kills = 0

    this.arrows = arrows
    this.field = field
    this.damage = damage
  }

  moveLeft() {
    // moves 1 square to the left, but does nothing if at the leftmost edge
    if (this.x === 0) {
      return;
    } else {
      this.x--;
    }
  }

  moveRight() {
    // moves 1 square to the right, but does nothing if at the rightmost edge
    if (this.x === Field.rows.length) {
      return;
    } else {
      this.x++;
    }
  }

  shoot() {
    // shoots all enemies in the current column, does nothing if out of arrows
    
  }

  outOfArrows() {
    // detect if out of arrows
  }
}

class Field {
  constructor(rows = 11, cols = 10) {
    this.grid = []
    this.numRows = rows
    this.numCols = cols

    for (let i = 0; i < this.numCols; i++) {
      const column = []
      for (let j = 0; j < this.numRows; j++) {
        column.push(null)
      }
      this.grid.push(column)
    }
  }

  static loadFromFileContents(contents) {
    // create a field from file contents, usage should be:
    // const field = Field.loadFromFileContents("10 x 11 / (5, 2), (5, 3), (2, 4)")
    
    const field = Field.loadFromFileContents(`10 x 11 / ${contents}`)
    return field;
  }

  placeEnemy(x, y) {
    this.grid[x][y] = new Enemy(x, y)
  }

  vacateTile(x, y) {
    // opposite of placeEnemy(), just marks a tile as null
    this.grid[x][y] = new Enemy(null, null)
  }

  getEnemiesAtColumn(column) {
    // gets all "alive" enemies in the given column number
    const fieldArray = str.split(this.field)

    for (let i = 0; i < fieldArray.length; i++) {
      if (fieldArray[i] == "(") {
        column.push(fieldArray[i + 1])
      } else {
        return;
      }
    }

  }

  damageEnemiesAtColumn(column, initialDamage) {
    // damage all enemies given the column number

    for (let i = 0; i < column.length; i++) {

      if (Enemy.x == column[i]) {
        let reducedDamage = Math.floor(this.hp -= initialDamage * 0.2); 
        return [reducedDamage, this.hp];
      } 
      else {
        return Math.floor(this.hp -= amount);
      }
    
    }

  }
}
