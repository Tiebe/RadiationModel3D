using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium139m";
        public override double halfLife { get; } = 19800.0d;
        public override double atomicWeight { get; } = 138.9122d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.87d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium139()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0102d, new GammaParticle(92910.0, 0.01334)), new(0.0018d, new GammaParticle(101200.0, 0.01225)), new(0.4d, new GammaParticle(113870.0, 0.01089)), new(0.0062d, new GammaParticle(147900.0, 0.00838)), new(0.0007030000000000001d, new GammaParticle(151400.0, 0.00819)), new(0.0007030000000000001d, new GammaParticle(172100.0, 0.0072)), new(0.0179d, new GammaParticle(209650.0, 0.00591)), new(0.0049d, new GammaParticle(214600.0, 0.00578)), new(0.012d, new GammaParticle(254600.0, 0.00487)), new(0.005600000000000001d, new GammaParticle(302700.0, 0.0041)), new(0.006d, new GammaParticle(340500.0, 0.00364)), new(0.0232d, new GammaParticle(362420.0, 0.00342)), new(0.0239d, new GammaParticle(403750.0, 0.00307)), new(0.0076d, new GammaParticle(424300.0, 0.00292)), new(0.0062d, new GammaParticle(475500.0, 0.00261)), new(0.0235d, new GammaParticle(547650.0, 0.00226)), new(0.0077d, new GammaParticle(572300.0, 0.00217)), new(0.005600000000000001d, new GammaParticle(601200.0, 0.00206)), new(0.0062d, new GammaParticle(673300.0, 0.00184)), new(0.040999999999999995d, new GammaParticle(701200.0, 0.00177)), new(0.263d, new GammaParticle(708100.0, 0.00175)), new(0.0058d, new GammaParticle(732400.0, 0.00169)), new(0.35100000000000003d, new GammaParticle(738200.0, 0.00168)), new(0.004d, new GammaParticle(772500.0, 0.0016)), new(0.042d, new GammaParticle(796500.0, 0.00156)), new(0.07d, new GammaParticle(802000.0, 0.00155)), new(0.063d, new GammaParticle(809600.0, 0.00153)), new(0.0172d, new GammaParticle(822100.0, 0.00151)), new(0.10300000000000001d, new GammaParticle(827800.0, 0.0015)), new(0.0017599999999999998d, new GammaParticle(852000.0, 0.00146)), new(0.0034999999999999996d, new GammaParticle(894800.0, 0.00139)), new(0.0039000000000000003d, new GammaParticle(900000.0, 0.00138)), new(0.076d, new GammaParticle(910100.0, 0.00136)), new(0.263d, new GammaParticle(982200.0, 0.00126)), new(0.032d, new GammaParticle(1006200.0, 0.00123)), new(0.0274d, new GammaParticle(1012300.0, 0.00122)), new(0.0151d, new GammaParticle(1024900.0, 0.00121)), new(0.035d, new GammaParticle(1075200.0, 0.00115)), new(0.0271d, new GammaParticle(1105300.0, 0.00112)), new(0.0012d, new GammaParticle(1151200.0, 0.00108)), new(0.0034000000000000002d, new GammaParticle(1165800.0, 0.00106)), new(0.0165d, new GammaParticle(1219600.0, 0.00102)), new(0.0134d, new GammaParticle(1226700.0, 0.00101)), new(0.0042d, new GammaParticle(1234600.0, 0.001)), new(0.0029d, new GammaParticle(1245700.0, 0.001)), new(0.00046d, new GammaParticle(1269500.0, 0.00098)), new(0.018600000000000002d, new GammaParticle(1322300.0, 0.00094)), new(0.0046d, new GammaParticle(1344800.0, 0.00092)), new(0.0033d, new GammaParticle(1364800.0, 0.00091)), new(0.0042d, new GammaParticle(1374700.0, 0.0009)), new(0.0032d, new GammaParticle(1463600.0, 0.00085)), new(0.005600000000000001d, new GammaParticle(1470200.0, 0.00084)), new(0.0014000000000000002d, new GammaParticle(1510500.0, 0.00082)), new(0.0032d, new GammaParticle(1680700.0, 0.00074)), new(0.048d, new GammaParticle(2060900.0, 0.0006)), new(0.00053d, new GammaParticle(2085000.0, 0.00059)), new(0.0013d, new GammaParticle(2201200.0, 0.00056)), new(0.046128d, new GammaParticle(511000.0, 0.00243)), new(0.154d, new GammaParticle(5637.0, 0.21995)), new(0.297d, new GammaParticle(35551.0, 0.03488)), new(0.54d, new GammaParticle(36027.0, 0.03441)), new(0.165d, new GammaParticle(40857.0, 0.03035)), new(0.207d, new GammaParticle(41266.0, 0.03005)), new(0.042d, new GammaParticle(41766.0, 0.02969)) } },
            { 0.13d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium139()), new(0.0084d, new GammaParticle(231150.0, 0.00536)), new(0.014158326d, new GammaParticle(5870.0, 0.21122)), new(0.020487144111008396d, new GammaParticle(36848.0, 0.03365)), new(0.03731040632126825d, new GammaParticle(37362.0, 0.03318)), new(0.011458352878061528d, new GammaParticle(42380.0, 0.02926)), new(0.014403149567723341d, new GammaParticle(42810.0, 0.02896)), new(0.002944796689661813d, new GammaParticle(43335.0, 0.02861)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    