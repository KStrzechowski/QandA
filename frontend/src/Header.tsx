import React from 'react';
import { UserIcon } from './Icons';

export const Header = () => (
  <div>
    <a href="./">Q & A</a>
    <input type="text" placeholder="Search..." />
    <a href="./sigin">
      <UserIcon />
      <span>Sign In</span>
    </a>
  </div>
);
