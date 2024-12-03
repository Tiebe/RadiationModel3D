using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium148m";
        public override double halfLife { get; } = 132.0d;
        public override double atomicWeight { get; } = 147.92437d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium148()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.000696752d, new GammaParticle(123000.0, 0.01008)), new(0.03085616d, new GammaParticle(129500.0, 0.00957)), new(0.010650352d, new GammaParticle(130800.0, 0.00948)), new(0.03185152d, new GammaParticle(142700.0, 0.00869)), new(0.0012939680000000002d, new GammaParticle(169200.0, 0.00733)), new(0.00398144d, new GammaParticle(271000.0, 0.00458)), new(0.003384224d, new GammaParticle(334800.0, 0.0037)), new(0.9605224d, new GammaParticle(394550.0, 0.00314)), new(0.000398144d, new GammaParticle(443400.0, 0.0028)), new(0.000597216d, new GammaParticle(457900.0, 0.00271)), new(0.005374944d, new GammaParticle(465600.0, 0.00266)), new(0.03782368d, new GammaParticle(481650.0, 0.00257)), new(0.06171232d, new GammaParticle(488830.0, 0.00254)), new(0.00049768d, new GammaParticle(540300.0, 0.00229)), new(0.000597216d, new GammaParticle(588600.0, 0.00211)), new(0.93265232d, new GammaParticle(631870.0, 0.00196)), new(0.0012939680000000002d, new GammaParticle(639500.0, 0.00194)), new(0.0012939680000000002d, new GammaParticle(640400.0, 0.00194)), new(0.00398144d, new GammaParticle(665800.0, 0.00186)), new(0.02090256d, new GammaParticle(753000.0, 0.00165)), new(0.99536d, new GammaParticle(784480.0, 0.00158)), new(0.028865440000000003d, new GammaParticle(808100.0, 0.00153)), new(0.8958240000000001d, new GammaParticle(882410.0, 0.00141)), new(0.011048496000000001d, new GammaParticle(883600.0, 0.0014)), new(0.001194432d, new GammaParticle(938300.0, 0.00132)), new(0.00099536d, new GammaParticle(952700.0, 0.0013)), new(0.00199072d, new GammaParticle(954300.0, 0.0013)), new(0.001891184d, new GammaParticle(971700.0, 0.00128)), new(0.000597216d, new GammaParticle(971700.0, 0.00128)), new(0.001393504d, new GammaParticle(1057700.0, 0.00117)), new(0.000597216d, new GammaParticle(1063700.0, 0.00117)), new(0.00149304d, new GammaParticle(1089700.0, 0.00114)), new(0.000696752d, new GammaParticle(1113700.0, 0.00111)), new(0.000895824d, new GammaParticle(1115000.0, 0.00111)), new(0.0036828319999999996d, new GammaParticle(1125200.0, 0.0011)), new(0.0024884d, new GammaParticle(1174000.0, 0.00106)), new(0.000696752d, new GammaParticle(1175400.0, 0.00105)), new(0.00199072d, new GammaParticle(1208200.0, 0.00103)), new(0.000597216d, new GammaParticle(1234700.0, 0.001)), new(0.00099536d, new GammaParticle(1250500.0, 0.00099)), new(0.002090256d, new GammaParticle(1282300.0, 0.00097)), new(0.000398144d, new GammaParticle(1295500.0, 0.00096)), new(0.0022893279999999998d, new GammaParticle(1297200.0, 0.00096)), new(0.000796288d, new GammaParticle(1317800.0, 0.00094)), new(0.00149304d, new GammaParticle(1336600.0, 0.00093)), new(0.0012939680000000002d, new GammaParticle(1346000.0, 0.00092)), new(0.002787008d, new GammaParticle(1366400.0, 0.00091)), new(0.0024884d, new GammaParticle(1424600.0, 0.00087)), new(0.01144664d, new GammaParticle(1425900.0, 0.00087)), new(0.00149304d, new GammaParticle(1475600.0, 0.00084)), new(0.001194432d, new GammaParticle(1476900.0, 0.00084)), new(0.000398144d, new GammaParticle(1540100.0, 0.00081)), new(0.003085616d, new GammaParticle(1546900.0, 0.0008)), new(0.0021897920000000003d, new GammaParticle(1555400.0, 0.0008)), new(0.001592576d, new GammaParticle(1578000.0, 0.00079)), new(0.00049768d, new GammaParticle(1606400.0, 0.00077)), new(0.00895824d, new GammaParticle(1618700.0, 0.00077)), new(0.00597216d, new GammaParticle(1667000.0, 0.00074)), new(0.001592576d, new GammaParticle(1714300.0, 0.00072)), new(0.005574016d, new GammaParticle(1715700.0, 0.00072)), new(0.00447912d, new GammaParticle(1748100.0, 0.00071)), new(0.00398144d, new GammaParticle(1834800.0, 0.00068)), new(0.002090256d, new GammaParticle(1845000.0, 0.00067)), new(0.001692112d, new GammaParticle(1957200.0, 0.00063)), new(0.001791648d, new GammaParticle(1997300.0, 0.00062)), new(0.002687472d, new GammaParticle(2308200.0, 0.00054)), new(0.6015464d, new GammaParticle(511000.0, 0.00243)), new(0.11715960628433741d, new GammaParticle(6858.0, 0.18079)), new(0.17572010613260283d, new GammaParticle(42308.0, 0.02931)), new(0.3161002089091614d, new GammaParticle(42996.0, 0.02884)), new(0.09992168870919774d, new GammaParticle(48802.0, 0.02541)), new(0.12620109283971673d, new GammaParticle(49326.0, 0.02514)), new(0.026279404130519005d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    