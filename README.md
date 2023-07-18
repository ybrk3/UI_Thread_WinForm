# UI Thread'i kitlemeden oluşturulan async yapı.

## Form uygulaması çalışırken UI Thread kullanılmaktadır. Oluşturduğumuz Thread yapısıyla async bir yapı oluşturduk. Ancak UI Thread'i farklı thread üzerinden çalıştırdığımız method'larla kitlememek adına Multi-Threading yapı kurulmuş ve bu Thread yapısı kendi içinde gruplanmıştır.
## Form Control elemanına log'lama ile birden fazla thread üzerinden request gittiğinde cross-thread exception fırlatmaktadır. Bunu engellemek adına "InvokeRequired" ile farklı Thread üzerinden request gelmesi durumunda "invoke" ile loglama methodu kendi içerisinde çağırılıp, "return" ile  method'dan çıkılarak bu hatanın fırlatılması engellenmiştir.

username="Admin"
password="123"
