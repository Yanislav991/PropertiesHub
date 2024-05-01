'use client'

import Link from 'next/link'
import React from 'react'
import { usePathname } from 'next/navigation'

const NavItem = (props: any) => {
    const currentPath = usePathname();
    const activeClass = 'block py-2 px-3 text-white bg-blue-700 rounded md:bg-transparent md:text-blue-700 md:p-0 dark:text-white md:dark:text-blue-500';
    const inactiveClass = 'block py-2 px-3 text-gray-900 rounded hover:bg-gray-100 md:hover:bg-transparent md:border-0 md:hover:text-blue-700 md:p-0 dark:text-white md:dark:hover:text-blue-500 dark:hover:bg-gray-700 dark:hover:text-white md:dark:hover:bg-transparent';
    return (
        <>
            <li>
                <Link href={props.href} className={currentPath === props.href ? activeClass : inactiveClass} aria-current="page">{props.name}</Link>
            </li>
        </>
    )
}

export default NavItem