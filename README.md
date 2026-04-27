# 🐍 Snake 3D (Unity URP)

A modern 3D Snake game built in Unity using URP, focused on smooth movement, clean architecture, and arcade-style gameplay.

---

## 🎯 Project Vision

This is not a classic grid-based snake clone.

The goal is to build a **polished, replayable arcade experience** with:

* Smooth, continuous movement
* Responsive steering controls
* A satisfying body-follow system
* Increasing gameplay pressure over time
* Clean and modular code architecture

---

## 🧩 Current Features

### 🟢 Core Movement

* Forward-based continuous movement
* Rotation-based steering (A/D or Left/Right)
* Frame-rate independent controls

### 🍎 Food System

* Randomized spawning within arena bounds
* Spawn padding to avoid edge placement
* Configurable height offset
* Prefab-based pickup system

### 💥 Interaction System

* Trigger-based collision detection
* Food consumption logic
* Automatic respawn on pickup

---

## 🧱 Architecture

The project is structured around modular systems:

* `SnakeController` → movement & steering
* `FoodSpawner` → food spawning logic
* `SnakeCollision` → interaction handling

Each system has a **single responsibility** to keep the project scalable and maintainable.

---

## 🎮 Gameplay Loop

Move → Find food → Eat → Respawn food → Repeat

This is the foundation for future systems like:

* Snake growth
* Scoring and combos
* Difficulty scaling
* Power-ups

---

## 🛠️ Tech Stack

* Unity (URP)
* C#
* New Input System

---

## 🚀 Roadmap

* [ ] Snake body follow system
* [ ] Growth mechanics
* [ ] Score & combo system
* [ ] Progressive difficulty
* [ ] Visual polish (particles, glow, feedback)
* [ ] Pickups (boost, magnet, shield)

---

## 📸 Screenshots

*Not available for now*

---

## 📄 License

MIT License
