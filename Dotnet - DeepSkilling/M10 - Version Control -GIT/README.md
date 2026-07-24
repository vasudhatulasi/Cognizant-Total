# Git Basics

## Overview
Git is a distributed version control system used to track changes in source code. It allows multiple developers to work on the same project efficiently.

## Features
- Version Control
- Branching and Merging
- Collaboration
- Remote Repositories
- Pull Requests

## Prerequisites
- Install Git
- Configure Git

```bash
git config --global user.name "Your Name"
git config --global user.email "your@email.com"
```

## Basic Git Commands

Initialize Repository
```bash
git init
```

Clone Repository
```bash
git clone <repository-url>
```

Check Status
```bash
git status
```

Stage Files
```bash
git add .
```

Commit Changes
```bash
git commit -m "Initial Commit"
```

View Commit History
```bash
git log
```

Create Branch
```bash
git branch feature
```

Switch Branch
```bash
git checkout feature
```

Create and Switch Branch
```bash
git checkout -b feature
```

Merge Branch
```bash
git merge feature
```

Add Remote Repository
```bash
git remote add origin <repository-url>
```

Push Changes
```bash
git push origin main
```

Pull Changes
```bash
git pull origin main
```

## Git Workflow
1. Create Repository
2. Add Files
3. Commit Changes
4. Create Branch
5. Merge Branch
6. Push to GitHub
7. Create Pull Request

