import React from 'react'
import FilterSideBar from '../components/FilterSideBar'
import AdsSection from '../components/AdsSection'
import Pager from '../components/Pager'

const Buy = () => {
    return (
        <>
            <section className="flex gap-7 p-4 dark:bg-gray-700 h-full">
                <FilterSideBar />
                <section>
                    <AdsSection />
                    <Pager pagesCount={5} />
                </section>
            </section>
        </>
    )
}

export default Buy