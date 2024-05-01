import React from 'react'
import FilterSideBar from '../components/FilterSideBar'
import AdsSection from '../components/AdsSection'

const Buy = () => {
    return (
        <>
            <section className="flex p-4 dark:bg-gray-800">
                <FilterSideBar />
                <AdsSection />
            </section>
        </>
    )
}

export default Buy