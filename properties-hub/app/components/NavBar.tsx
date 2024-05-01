import Link from 'next/link'
import React from 'react'
import NavItem from './NavItem'

const NavBar = () => {
    return (
        <nav className="bg-white border-gray-200 dark:bg-gray-900">
            <div className="max-w-screen-xl flex flex-wrap items-center justify-between mx-auto p-4">
                <Link href="/" className="flex items-center space-x-3 rtl:space-x-reverse">
                    <img src="logo.svg" className="h-8" alt="PropertiesHub Logo" />
                    <span className="self-center text-2xl font-semibold whitespace-nowrap dark:text-white">PropetiesHub</span>
                </Link>
                <div className="flex justify-end items-center space-x-4">
                    <div className="hidden w-full md:block md:w-auto" id="navbar-default">
                        <ul className="font-medium flex flex-col p-4 md:p-0 mt-4 border border-gray-100 rounded-lg bg-gray-50 md:flex-row md:space-x-8 rtl:space-x-reverse md:mt-0 md:border-0 md:bg-white dark:bg-gray-800 md:dark:bg-gray-900 dark:border-gray-700">
                            <NavItem href="/" name="Home" />
                            <NavItem href="/buy" name="Buy" />
                            <NavItem href="/rent" name="Rent" />
                            <NavItem href="/agent" name="Find Agent" />
                        </ul>
                    </div>
                    <button type="button" className="text-white bg-gray-800 hover:bg-gray-900 focus:outline-none focus:ring-4 focus:ring-gray-300 font-medium rounded-full text-sm px-5 py-2.5 me-2 mb-2 dark:bg-gray-800 dark:hover:bg-gray-700 dark:focus:ring-gray-700 dark:border-gray-700">Sign In</button>
                </div>
            </div>
        </nav>
    )
}

export default NavBar