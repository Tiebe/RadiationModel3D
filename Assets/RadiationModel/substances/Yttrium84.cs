using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium84";
        public override double halfLife { get; } = 2370.0d;
        public override double atomicWeight { get; } = 83.92067d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium84()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.002949d, new GammaParticle(241200.0, 0.00514)), new(0.007864d, new GammaParticle(288300.0, 0.0043)), new(0.101249d, new GammaParticle(462800.0, 0.00268)), new(0.095351d, new GammaParticle(602200.0, 0.00206)), new(0.02949d, new GammaParticle(635000.0, 0.00195)), new(0.044235d, new GammaParticle(658300.0, 0.00188)), new(0.113045d, new GammaParticle(660600.0, 0.00188)), new(0.047184d, new GammaParticle(680600.0, 0.00182)), new(0.05799699999999999d, new GammaParticle(703600.0, 0.00176)), new(0.037354d, new GammaParticle(705800.0, 0.00176)), new(0.983d, new GammaParticle(793100.0, 0.00156)), new(0.0112062d, new GammaParticle(932200.0, 0.00133)), new(0.014843299999999999d, new GammaParticle(967200.0, 0.00128)), new(0.77657d, new GammaParticle(974300.0, 0.00127)), new(0.008847d, new GammaParticle(980200.0, 0.00126)), new(0.040303000000000005d, new GammaParticle(994800.0, 0.00125)), new(0.025558d, new GammaParticle(1001100.0, 0.00124)), new(0.56031d, new GammaParticle(1039700.0, 0.00119)), new(0.0075691d, new GammaParticle(1063500.0, 0.00117)), new(0.044235d, new GammaParticle(1092300.0, 0.00114)), new(0.030473d, new GammaParticle(1110300.0, 0.00112)), new(0.01966d, new GammaParticle(1119600.0, 0.00111)), new(0.003932d, new GammaParticle(1129600.0, 0.0011)), new(0.031456d, new GammaParticle(1144200.0, 0.00108)), new(0.006881000000000001d, new GammaParticle(1154900.0, 0.00107)), new(0.004915d, new GammaParticle(1185100.0, 0.00105)), new(0.010813d, new GammaParticle(1232900.0, 0.00101)), new(0.065861d, new GammaParticle(1255000.0, 0.00099)), new(0.026541000000000002d, new GammaParticle(1262600.0, 0.00098)), new(0.008847d, new GammaParticle(1270700.0, 0.00098)), new(0.0021626d, new GammaParticle(1280800.0, 0.00097)), new(0.028506999999999998d, new GammaParticle(1330700.0, 0.00093)), new(0.028506999999999998d, new GammaParticle(1330700.0, 0.00093)), new(0.001966d, new GammaParticle(1362800.0, 0.00091)), new(0.003932d, new GammaParticle(1370800.0, 0.0009)), new(0.006881000000000001d, new GammaParticle(1411100.0, 0.00088)), new(0.015728d, new GammaParticle(1453400.0, 0.00085)), new(0.003932d, new GammaParticle(1463300.0, 0.00085)), new(0.008847d, new GammaParticle(1469900.0, 0.00084)), new(0.008847d, new GammaParticle(1479200.0, 0.00084)), new(0.062912d, new GammaParticle(1502800.0, 0.00083)), new(0.003932d, new GammaParticle(1520200.0, 0.00082)), new(0.005898d, new GammaParticle(1557600.0, 0.0008)), new(0.017694d, new GammaParticle(1614500.0, 0.00077)), new(0.00983d, new GammaParticle(1628000.0, 0.00076)), new(0.0034405000000000004d, new GammaParticle(1638600.0, 0.00076)), new(0.025558d, new GammaParticle(1654600.0, 0.00075)), new(0.014745d, new GammaParticle(1711000.0, 0.00072)), new(0.0220192d, new GammaParticle(1744400.0, 0.00071)), new(0.018677d, new GammaParticle(1763600.0, 0.0007)), new(0.0014745d, new GammaParticle(1805000.0, 0.00069)), new(0.010813d, new GammaParticle(1810800.0, 0.00068)), new(0.022609d, new GammaParticle(1918000.0, 0.00065)), new(0.002949d, new GammaParticle(2006700.0, 0.00062)), new(0.004915d, new GammaParticle(2052900.0, 0.0006)), new(0.008847d, new GammaParticle(2093300.0, 0.00059)), new(0.005111599999999999d, new GammaParticle(2150900.0, 0.00058)), new(0.021626d, new GammaParticle(2295300.0, 0.00054)), new(0.011796d, new GammaParticle(2309500.0, 0.00054)), new(0.0012778999999999998d, new GammaParticle(2807800.0, 0.00044)), new(0.002949d, new GammaParticle(2908000.0, 0.00043)), new(0.001966d, new GammaParticle(2945000.0, 0.00042)), new(0.001966d, new GammaParticle(2968000.0, 0.00042)), new(0.000983d, new GammaParticle(3315000.0, 0.00037)), new(1.6780000000000002d, new GammaParticle(511000.0, 0.00243)), new(0.00474041991704812d, new GammaParticle(1890.0, 0.656)), new(0.02987494947543322d, new GammaParticle(14098.0, 0.08794)), new(0.05739663684040964d, new GammaParticle(14165.0, 0.08753)), new(0.014171978839785103d, new GammaParticle(15898.0, 0.07799)), new(0.016014336088957165d, new GammaParticle(15955.0, 0.07771)), new(0.0018423572491720634d, new GammaParticle(16085.0, 0.07708)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    