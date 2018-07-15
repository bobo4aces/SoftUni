function formFiller (username, email, phoneNumber, form) {
    let usernamePattern = /<![A-Za-z]+!>/;
    let emailPattern = /<@[A-Za-z]+@>/;
    let phoneNumberPattern = /<\+[A-Za-z]+\+>/;
    form.forEach(line => {
        line = line.replace(/<![A-Za-z]+!>/g, username);
        line = line.replace(/<@[A-Za-z]+@>/g, email);
        line = line.replace(/<\+[A-Za-z]+\+>/g, phoneNumber);
        console.log(line);
    });
}
formFiller('Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    ['Hello, <!username!>!',
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']
);