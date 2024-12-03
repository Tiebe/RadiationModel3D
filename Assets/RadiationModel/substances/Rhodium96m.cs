using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium96m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium96m";
        public override double halfLife { get; } = 90.6d;
        public override double atomicWeight { get; } = 95.91451d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium96()), new(0.00094d, new GammaParticle(52000.0, 0.02384)), new(0.0259786202d, new GammaParticle(2892.0, 0.42871)), new(0.07620498717332613d, new GammaParticle(20073.0, 0.06177)), new(0.14427297836676664d, new GammaParticle(20215.0, 0.06133)), new(0.03917927483697018d, new GammaParticle(22806.0, 0.05436)), new(0.04568303445990723d, new GammaParticle(22957.0, 0.05401)), new(0.00650375962293705d, new GammaParticle(23170.0, 0.05351)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium96()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.001d, new GammaParticle(455900.0, 0.00272)), new(0.0039000000000000003d, new GammaParticle(471400.0, 0.00263)), new(0.00077d, new GammaParticle(533700.0, 0.00232)), new(7.3e-05d, new GammaParticle(591100.0, 0.0021)), new(0.035d, new GammaParticle(685470.0, 0.00181)), new(0.0039000000000000003d, new GammaParticle(766800.0, 0.00162)), new(0.028999999999999998d, new GammaParticle(808600.0, 0.00153)), new(0.39d, new GammaParticle(832520.0, 0.00149)), new(0.0077d, new GammaParticle(944070.0, 0.00131)), new(0.0085d, new GammaParticle(1006500.0, 0.00123)), new(0.087d, new GammaParticle(1098200.0, 0.00113)), new(0.0062d, new GammaParticle(1242140.0, 0.001)), new(0.00193d, new GammaParticle(1330500.0, 0.00093)), new(0.017d, new GammaParticle(1451900.0, 0.00085)), new(0.0042d, new GammaParticle(1479000.0, 0.00084)), new(0.0046d, new GammaParticle(1559000.0, 0.0008)), new(0.069d, new GammaParticle(1692300.0, 0.00073)), new(0.016d, new GammaParticle(1743100.0, 0.00071)), new(0.016d, new GammaParticle(1743100.0, 0.00071)), new(0.0058d, new GammaParticle(1773400.0, 0.0007)), new(0.0089d, new GammaParticle(1907500.0, 0.00065)), new(0.0052d, new GammaParticle(1930900.0, 0.00064)), new(0.025d, new GammaParticle(2163800.0, 0.00057)), new(0.018000000000000002d, new GammaParticle(2257600.0, 0.00055)), new(0.0014000000000000002d, new GammaParticle(2283900.0, 0.00054)), new(0.005d, new GammaParticle(2428300.0, 0.00051)), new(0.0077d, new GammaParticle(2459100.0, 0.0005)), new(0.0062d, new GammaParticle(2576100.0, 0.00048)), new(0.0031d, new GammaParticle(2840200.0, 0.00044)), new(0.00039d, new GammaParticle(3090100.0, 0.0004)), new(0.0019d, new GammaParticle(3119100.0, 0.0004)), new(0.0014000000000000002d, new GammaParticle(3261500.0, 0.00038)), new(0.7440000000000001d, new GammaParticle(511000.0, 0.00243)), new(0.00223215412515d, new GammaParticle(2737.0, 0.45299)), new(0.01001255270579466d, new GammaParticle(19150.0, 0.06474)), new(0.018999151244392144d, new GammaParticle(19279.0, 0.06431)), new(0.005105760290717041d, new GammaParticle(21736.0, 0.05704)), new(0.005932893457813201d, new GammaParticle(21875.0, 0.05668)), new(0.0008271331670961607d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    