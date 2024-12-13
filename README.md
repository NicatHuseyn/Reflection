
  <h1>Reflection</h1>

  <p>
      C#-da reflection, runtime-da project içərisindəki hər hansı bir tipin
      (class, interface, struct, enum, delegate və.s.) məlumatlarını əldə etmə
      və bu məlumatları manipulyasiya etmə haqqını verən bir özəllikdir.
      <br />
      Yəni proqramın öz strukturunu, anatomiyasını, xımını (fundamentini)
      incələmək və dəyişdirməyə imkan yaradan bir özəllikdir.
    </p>

  <h3><strong>Reflection-un məqsədi nədir?</strong></h3>

  <ol>
      <li>
        <strong>Type Məlumatını İncələmək</strong><br />
        Reflecion bir tipin adı, property-ləri, metodları, field-ları və.s. kimi
        bu tərzdə məlumatları əldə etməyimizə imkan verir. Beləcə reflection,
        runtime-da tip haqqında dinamik qərarlar vermək və ya tipin
        özəlliklərinə dinamik olaraq əldə etmək üçün istifadə edilə bilər.
      </li>
      <li>
        <strong>Yeni Bir Tip Yaratmaq Və Yükləmək</strong> <br />
        Reflection, runtime-da yeni bir tipin yaradılmasına yaxud var olan bir
        dll faylındakı tipin yüklənməsinə imkan verir. Bu sayədə proqramın
        çalışma müddətində ehtiyacı olan tipləri yaratmaq və ya paket proqram
        yanaşması göstərmək üçün imkan verir.
      </li>
      <li>
        <strong>Memberları Dinamik Çalışdırmaq</strong> <br />
        Reflection ilə runtime-da metod və ya property kimi member-ları
        çalışdıra bilərik. Bu özəllik sayəsində member-ları dinamik olaraq seçə
        bilər və əməliyyatlarımızı daha maneratik şəkildə edə bilərik.
      </li>
    </ol>

  <h3><strong>Reflection-un məqsədi nədir?</strong></h3>

  <ol>
      <li>
        <strong>Software analysis və tool development</strong><br />
        Reflection, bir compile üzərində analiz etmə və bu compile ilə əlaqəli
        məlumatları çıxarmaq üçün istifadə edilə bilər. Xüsusən kod analizi və
        proqram development tool-ları kimi proqramları hazırlamaqda istifadəyə
        yararlıdır.
      </li>

  <li>
        <strong>Plugin Based və Modular Sistemlər</strong><br />
        Reflection, dinamik olaraq yüklənə bilən və istifadə edilən plugin-ləri
        və ya modulları idarə etmək üçün istifadə edilə bilər. Beləcə müəyyən
        contract-ları həyata keçirdiyi təqdirdə runtime-da dinamik davranış
        göstərə bilən plugin based sistemlər hazırlaya bilərik.
      </li>

  <li>
        <strong>Data Serialize Və Deserialize</strong><br />
        Reflection ilə obyektləri data axışına uyğun formata çevirmək və bu
        formatdan obyekti geri əldə etmə işlərində istifadə edilə bilər.
      </li>

  <li>
        <strong>Configuration Management</strong><br />
        Reflection, xüsusilə configuratin fayllarındakı məlumatları oxumaq və bu
        məlumatları uyğun obyektlərə dönüşdürməkdə istifadə edilə bilər. Bu
        configuration fayıllarındakı dəyişikliklərə daha flexible bir şəkildə
        reaksiya vermə imkanı qazandıracaq.
      </li>

  <li>
        <strong>Unit Test Framewoks</strong><br />
        Reflection, unit test framework-ləri tərəfindən istifadə edilən bir
        özəllikdir.
      </li>

  <li>
        <strong>Data Binding</strong><br />
        Reflection, database sorğuların alınan nəticələri object-ə dönüşdürmək
        və bu object-ləri user interfeysinə bind etmək məqsədi ilə istifadə
        edilə bilər.
      </li>
      <li>
        <strong>Dependency İnjection</strong><br />
        Əgər dependency injection davranışı ortaya qoyan bir İoC yaradacaq
        olsaq, obyektlərimizin davranışını Reflection ilə yönləndirə bilərik.
      </li>
    </ol>

  <h3>
      <strong
        >Bir proqramda reflection istifadə etmək istəyiriksə, 2 nöqtədən giriş
        edə bilərik.</strong
      >
    </h3>
    <ol>
      <li>
        Proqram səviyyəsində reflection-a girə bilərik. Yəni base olaraq,
        application alınacaq. Proqram səviyyəsində girsək, Assembly-dən istifadə
        edəcəyik.
      </li>
      <li>
        Proqram içərisindəki hər hansı bir tip səviyyəsində giriş edə bilərik.
        Yəni bir tipin memberlarını əldə etmək istəsək istifadə edə bilərik.
        Type səviyyəsində giriş etsək Type class-ından istifadə edəcəyik.
      </li>
    </ol>

  <h1>Assembly Nədir?</h1>

  <p>
      Assembly, proqrama qarşılıq gələn (proqramı təmsil edən) ya da proqramın
      compile edilmiş və nəticədə .dll faylı yaratmış halı olaraq xarakterizə
      olunan bir anlayışdır. <br />
      .Net Compile Time və Run-Time Assembly olmaqla iki tip assembly vardır.
      <br />
      Compile-Time Assembly source kod-ların compile edilməsi, nəticəsində əldə
      edilən .dll yaxud .exe extension-a sahib fayllardır. <br />
      Run-Time Assembly, dinamik olaraq yaradılan və yüklənə bilən assembly-dir.
      Bizlər reflection ilə run-time assembly məlumatlarını əldə edəcəyik.
    </p>

  <h1>Assembly Class-ı Nədir?</h1>

  <p>
      Bizlər assembly səviyyəsində reflection istifadə edəcəyiksə,
      <strong>System.Reflecion</strong> namespace-i altında olan
      <strong>Assembly</strong> class-ından istifadə edəcəyik. Bu class
      sayəsində proqramdakı bütün metadatalara, modularlıq və tiplərə daxil olma
      (üzərində işləmə) biləcək və işlərimizi görə biləcəyik.
    </p>

  <div style="width: 600px; margin: 10px 0">
      <img style="width: 600px" src="https://github.com/user-attachments/assets/03b68e05-8aeb-4784-bd61-40c92b36ac09" alt="" />

  </div>

  <p>
      Yuxarıdakı koddan görüldüyü kimi Assembly class-ı vasitəsilə
      GetExecutingAssembly metodu vasitəsilə o adna çalışan, assembly-nin,
      proqramın içərisindəki member-lərin bütün bilgilərini mənə verəcək.
    </p>

  <p>
      Elə bu səbəbdən GetTypes metodu ilə də bu assembly içərisindəki strukturu
      ciddiyə almadan bütün tipləri mən gətirəcək. <br />
      <strong
        >Burada diqqət etməliyik ki, “GetExecutingAssembly” hansı proyektdə
        çağırılırsa o proyektin member-larını mənə verir, bütün solution altında
        olanları yox!</strong
      >
      <br />
      Həmçinin Assembly sinifi ilə başqa bir assembly-də olan dataları da
      incələyə bilərik. Bunun üçün aşağıdakı kimi
      <strong>Load</strong> funksiyasının istifadə edilməsi kifayyətdir.
    </p>

  <div style="width: 400px; margin: 10px 0">
      <img style="width: 400px" src="https://github.com/user-attachments/assets/9d485a85-f191-44be-a081-9df2a9c2dfc6" alt="" />
    </div>

  <h1>Module Nədir?</h1>

  <p>
      Module, bir assembly içərisində istifadə edilən .dll fayllarıdır deyə
      bilərik. Yəni assembly içərisində fərqli bir assembly-dir. Amma bu module
      adlanır.
    </p>

  <div style="width: 400px; margin: 10px 0">
      <img style="width: 400px" src="https://github.com/user-attachments/assets/d082e199-d320-4805-a3f1-4b8f6d7b570d" alt="" />
    </div>

  <p>
      Görüldüyü kimi bir solution içərisində bir classlibrary-i bir reflection
      console proyektinə reference edirik, yəni əlavə edirik. <br />
      Modulları əldə etmək üçün aşağıdakı kimi bir kod yaza bilərik.
    </p>

  <div style="width: 600px; margin: 10px 0">
      <img style="width: 600px" src="https://github.com/user-attachments/assets/3e050f4c-782b-47a7-a951-ac0f36bf85cd" alt="" />
    </div>

  <h1>Type və Type Discovery</h1>

  <p>
      Runtime-da bir tipin (class, interface, struct, record, enum, delegate
      və.s.) təmsilini təmsil etmək üçün <strong>Type</strong> class-ından
      isrtifadə edirik. Burada dediyimiz təmsil, referans cəhətdən təmsil deyil!
      Type bir tipin metodlarını, property-lərini field-larını və digər
      özəllikləri kimi bütün məlumatlarını əhatə edən bir tipdir. Bir tipin
      Type-ı əldə etmək istəyiriksə, aşağıdakı üsullardan istifadə edə bilərik.
    </p>

  <ul>
      <li>
        <h3><strong>GetType() Funksiyası:</strong></h3>
        Bir obyektin tipinə xas olan məlumatları əldə etmək istəyirsək, GetType
        metodunu birbaşa çağırıb reflection-a girə bilərik. <br />
        <div style="width: 400px; margin: 10px 0">
          <img style="width: 400px" src="https://github.com/user-attachments/assets/a798b1ed-9c0d-417e-be59-8cb81f6876ec" alt="" />
        </div>
      </li>
      <li>
        <h3><strong>typeof Keyword-ü:</strong></h3>
        typeof keyword-ü ilə də bir tipin birbaşa reflection-una girə bilər və
        məlumatlarını Type olaraq əldə edə bilərik. <br />
        <div style="width: 300px; margin: 10px 0">
          <img style="width: 300px" src="https://github.com/user-attachments/assets/5e49513c-3463-4380-9250-7b7df0d02e92" alt="" />
        </div>
      </li>
      <li>
        <h3><strong>Assembly üzərindən GetType():</strong></h3>
        Bir tipin reflection-una Assembly vasitəsilə də girə bilər və Type
        obyekti ilə əldə edə bilərik <br />
        <div style="width: 400px; margin: 10px 0">
          <img style="width: 400px" src="https://github.com/user-attachments/assets/55fb3f99-948b-4a74-bdb0-9e1b74847ccc" alt="" />
        </div>
      </li>
    </ul>

  <p>
      Məhz bu üsullarla runtime-da mövcud tipləri bu üsullardan hər hansı biri
      ilə yoxlayır və reflection-a giririksə, buna Type Discovery deyilir.
      <br />
      Amma Type Discovery istifadə edərkən bəzi şeylərə diqqət etməliyik.
    </p>

  <strong>Tip Güvənliyi:</strong>
    Reflection tip güvənliyi cəhətdən zəif bir mexanizmdir. Xüsusilə tip ya da
    member adlarını string olaraq istifadə etmək halı ola biləcək yazı
    xətalarına yaxud səhv adlandırılmış tiplərlə əlaqəli səhvlərə yol aça bilər.
    Bu kimi xətalara qaşılıq isə nameof keyword-ündən istifadə edirik.
    <br />
    <br />

  <strong>Performance:</strong>
    Reflection maliyyətli bir işdir. Çünki .Net dil compiler-ı tərəfindən
    yaradılan assembly faylları içərisində olan metadata məlumatlarını oxuyaraq
    əməliyyat həyata keçirir. Bu səbəbdən type discovery davranışını ehtiyac
    xarici yerdə istifadə etməkdən əlavə ehtiyac olan nöqtələrdə istifadə etməyə
    çalışmalıyıq.
    <br />
    <br />

  <strong>Davamlılıq:</strong>
    Reflection, kodu daha qarışıq bir hala gətirə bilər və davamlılığını da
    azalda bilər. Bu səbəbdən tip bilgisi əldə etmə və dinamik manipuliyasiya
    etmə əməliyyatları proqramın ehtiyaclarına uyğun və başa düşülən
    edilməlidir.
    <br />
    <br />

  <strong>Xəta Kontrolu:</strong>
    Reflection istifadə edəndə ola biləcək xətalara qarşı diqqətli bir kod
    yazmaq lazımdır. Məsələn, bir tipi tapmaması, bir metodun olmaması kimi
    halları kontrol etmək və ona görə əməliyyat etmək lazımdır.
    <br />
    <br />

  <h1>Reflection İlə Member-lara Daxil Olmaq</h1>

  <div style="width: 700px; margin: 10px 0">
      <img style="width: 700px" src="https://github.com/user-attachments/assets/0745f692-5992-44d5-ae54-b53670348ae9" alt="" />
    </div>

  <p>
      Görüldüyü kimi reflection ilə bir tipin memberlarına əldə etmək üçün uyğun
      metodları istifadə etmək kifayyətdir. Bu metodlar sayəsində əlaqəli tipə
      aid bütün dataları əldə edə bilirik.
    </p>

  <h1>Property Dəyəri Get və Set Etmək</h1>
    <p>
      Bir property-nin dəyərlərini get və set edə bilmək üçün aşağıdakı kimi
      əməliyyatlar edə bilərik.
    </p>

  <div style="width: 800px; margin: 10px 0">
      <img style="width: 800px" src="https://github.com/user-attachments/assets/38d3843a-0b06-4d03-9528-de41588e358c" alt="" />
    </div>
    <br />

  <strong>Metod çalışdırma isə aşağıdakı kimidir.</strong>
    <br />

  <div style="width: 800px; margin: 10px 0">
      <img style="width: 800px" src="https://github.com/user-attachments/assets/78f09637-634d-4286-ae89-2a5b9c2d0e2c" alt="" />
    </div>
    <br />

  <strong
      >Əgər metod parametr alarsa, bu zaman aşağıdakı kimi edəcəyik.</strong
    >

  <div style="width: 700px; margin: 10px 0">
      <img style="width: 700px" src="https://github.com/user-attachments/assets/67dbbd8a-0e40-409f-8a4a-deba818c7d5c" alt="" />
    </div>
    <br />

  <p>
      Parametri yuxarıdakı kimi göndəririk. Əgər birdən çox parametr olsa, bu
      zaman vergül ilə sıra ilə göndərəcəyik array-in içərisində.
    </p>

  <h3>Dynamic Metod</h3>

  <p>
      Çox az hallarda olsa da dinamik olaraq metod hazırlayıb istifadə etmək
      lazım ola bilər. Tipik olaraq compile zamanı metod yaratma runtime-da da
      etməyimizə imkan yaradır.
    </p>

  <h1>Reflection İlə Private Member-lara Daxil Olma</h1>

  <p>
      Kimsə deyirsə, bir member private olarsa, kimsə əldə edə bilməz! Xeyr!
      Əldə edə bilər.
      <br />
      <br />
      Bizlər reflection ilə bir tipin içərisindəki private, internal ya da
      protected olan member-lara daxil ola bilərik.
    </p>

  <div style="width: 700px; margin: 10px 0">
      <img style="width: 700px" src="https://github.com/user-attachments/assets/832f45df-fac5-4ac5-9c29-2b6f259b6c71" alt="" />
    </div>
    <br />
    <p>Yuxarıdakı kimi kod yazdıqda private olanların gəlmədiyini görürük.</p>
    <br />

  <div style="width: 600px; margin: 10px 0">
      <img style="width: 600px" src="https://github.com/user-attachments/assets/754752fa-037e-4fb7-b8df-26810bbb4632" alt="" />
    </div>

  <p>
      Yuxarıdakı kimi <strong>BindingFlags enumunu </strong> istifadə edərsək
      sadəcə private memberları əldə edəcəyik. Əgər public olanları da əldə
      etmək istərsək, bu zaman “Public” də əlavə etməliyik. Aşağıdakı kimi
    </p>
    <br />

  <div style="width: 700px; margin: 10px 0">
      <img style="width: 700px" src="https://github.com/user-attachments/assets/c5cb5582-2eba-481f-80eb-d557f8de7beb" alt="" />
    </div>

  <h3>
      <strong
        >Bütün dəyərləri gətirdik gətirməyinə bəs Private member-ların dəyərini
        oxuya bilərikmi?</strong
      >
      <br />
      <p>
        Artıq burada property adlarını GetProperty() metodu ilə tutduqda
        nameof-dan istifadə edə bilmərik.
      </p>
    </h3>

  <div style="width: 700px; margin: 10px 0">
      <img style="width: 700px" src="https://github.com/user-attachments/assets/876b7144-8835-4d24-ad74-da3e995af7d1" alt="" />
    </div>

  <p>
      Yuxarıdakı kimi bir çalışma edərək private property-lərin dəyərlərini də
      get edə bilərik. <br />
      Eyni qaydada metodları da çalışdıra bilərik.
    </p>

  <div style="width: 700px; margin: 10px 0">
      <img style="width: 700px" src="https://github.com/user-attachments/assets/c4cfd9d1-dad5-40bc-9c3a-20ae92325998" alt="" />
    </div>

  <p>
      Görüldüyü kimi reflection vasitəsi ilə private daxil olmaqla bütün
      dəyərləri əldə edə bilirik. Bu hal reflection-un neqativ bir tərəfidir.
    </p>

  <h1>
      <strong
        >Bir Şeyi Həll Edə Bilmirsənsə, Həll Yolu Reflection-dadır...</strong
      >
    </h1>
