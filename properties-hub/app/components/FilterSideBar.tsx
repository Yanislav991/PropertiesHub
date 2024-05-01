import React from 'react'

const FilterSideBar = () => {
    return (
        <>
            <aside className="p-4 dark:bg-gray-800 w-2/12 h-auto">
                <section className="dark:text-white light:text-gray-800">
                    <form className="max-w-sm mx-auto gap-6 flex flex-wrap">
                        <div className="mb-5 w-full">
                            <label htmlFor="sortBy" className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Sort By</label>
                            <select id="sortBy" className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                                <option value="">Select Sorting Option</option>
                                <option value="price_asc">Price: Low to High</option>
                                <option value="price_desc">Price: High to Low</option>
                                <option value="size_asc">Size: Low to High</option>
                                <option value="size_desc">Size: High to Low</option>
                            </select>
                        </div>
                        <div className="mb-5 w-full">
                            <label htmlFor="propertySize" className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Property Size (sq.ft)</label>
                            <input type="number" id="propertySize" min="0" className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Enter Property Size" />
                        </div>
                        <div className="mb-5 w-full">
                            <label htmlFor="propertyType" className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Property Type</label>
                            <select id="propertyType" className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                                <option value="">Select Property Type</option>
                                <option value="flat">Flat</option>
                                <option value="2_rooms_flat">2 Rooms Flat</option>
                                <option value="3_rooms_flat">3 Rooms Flat</option>
                                <option value="many_rooms_flat">Many Rooms Flat</option>
                                <option value="house">House</option>
                            </select>
                        </div>
                        <div className="mb-5 w-full">
                            <label htmlFor="priceRange" className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Price Range (Select Currency)</label>
                            <select id="priceRange" className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                                <option value="">Select Currency</option>
                                <option value="BGN">BGN</option>
                                <option value="EUR">EUR</option>
                                <option value="USD">USD</option>
                            </select>
                            <section className="flex gap-3.5">
                                <input type="number" id="minPriceRangeValue" min="0" className="mt-2 bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Min Price" />
                                <input type="number" id="maxPriceRangeValue" min="0" className="mt-2 bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Max Price" />
                            </section>

                        </div>
                        <div className="mb-5 w-full flex justify-around">
                            <button type="submit" className="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">Filter</button>
                            <button type="button" className="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">Clear Filter</button>
                        </div>
                    </form>

                </section>
            </aside>
        </>
    )
}

export default FilterSideBar