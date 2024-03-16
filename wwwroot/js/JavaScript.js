
	function formatPriceWithCommas(price) {
		// Handle negative values and decimals correctly
		const absolutePrice = Math.abs(Number(price));
	const parts = absolutePrice.toFixed(2).split('.');

	// Ensure integer part has commas for thousands (locale-specific formatting recommended)
	let formattedInteger = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, ',');

	// Combine formatted integer and decimal part
	const formattedPrice = formattedInteger + (parts[1] ? '.' + parts[1] : '');

	return formattedPrice;
	}

	// Format prices dynamically (consider using data attributes or alternative approaches)
	document.querySelectorAll('#formattedPrice_*')
		.forEach(element => {
			const price = element.textContent.replace(/[^0-9.]/g, ''); // Extract numeric value
	element.textContent = formatPriceWithCommas(price);
		});
