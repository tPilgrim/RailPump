# 🚄 Rail Pump - 2D Endless Runner

## 📖 Overview
**Rail Pump** is a fast-paced 2D endless runner set in a neon-lit cyberpunk metropolis. Players ride high-speed rails suspended above the city, dodging obstacles and switching tracks to survive as long as possible.

<p float="left">
<img src="Screenshots/Rail Pump 1.png" width="350"/>
  <img src="Screenshots/Rail Pump 2.png" width="350"/>
  <img src="Screenshots/Rail Pump 3.png" width="350"/>
</p>

## 🎯 Features
- 🚄 Endless runner gameplay
- 🔀 Multi-lane (track-switching) system
- ⚡ Increasing difficulty over time
- 🧱 Dynamic obstacle avoidance
- 🌆 Procedural environment spawning
- 🎵 Adaptive audio effects
- 🏆 High score system

## 🕹️ Controls
- **W / ↑ Arrow** → Move up (switch track)
- **S / ↓ Arrow** → Move down (switch track)
- **Space** → Pause / open menu

## 🧠 Game Mechanics

### 🚄 Movement System
- Player moves automatically forward
- Speed gradually increases over time
- Movement is constrained to **3 tracks**

### 🔀 Track Switching
- Instant lane switching with smooth vertical motion
- Input is limited to prevent spam
- Audio feedback for each switch

### ⚠️ Obstacles
- Colliding with an obstacle:
  - Ends the run
  - Triggers game over screen

### 🌆 Procedural Environment
- Background segments spawn dynamically
- Old segments are destroyed after leaving view
- Creates the illusion of an infinite world

### 🏁 Scoring System
- Score is based on **distance traveled**
- Automatically updates in real-time
- High score is saved using `PlayerPrefs`

## 💻 Code Structure

### 🚄 Player / Train Controller
Handles:
- Forward movement
- Speed scaling
- Track switching
- Collision detection
- Audio feedback

### 🧮 Score System
Handles:
- Real-time score calculation
- High score persistence

### 🌆 Background System
Handles:
- Procedural spawning of environment
- Cleanup of old objects

### 📋 Menu System
Handles:
- Pause menu
- Restart functionality
- Scene transitions
