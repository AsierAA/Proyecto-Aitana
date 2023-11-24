function toggleVehicleDetails(userId) {
    var details = document.getElementById('VehicleDetails_' + userId);
    if (details.style.display === 'none') {
        details.style.display = 'block';
    } else {
        details.style.display = 'none';
    }
}

function toggleUserDetails(userId) {
    var details = document.getElementById('UserDetails_' + userId);
    if (details.classList.contains('hidden')) {
        details.classList.remove('hidden');
    } else {
        details.classList.add('hidden');
    }
}