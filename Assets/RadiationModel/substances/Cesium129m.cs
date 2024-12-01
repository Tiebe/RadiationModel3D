using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium129m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 128.90668d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium129()), new(2.3e-06d, new GammaParticle(6550.0, 0.18929)), new(0.000789d, new GammaParticle(53200.0, 0.02331)), new(0.008942d, new GammaParticle(129140.0, 0.0096)), new(0.0012624d, new GammaParticle(135610.0, 0.00914)), new(0.526d, new GammaParticle(149050.0, 0.00832)), new(0.35768d, new GammaParticle(182320.0, 0.0068)), new(0.06364600000000001d, new GammaParticle(237650.0, 0.00522)), new(0.33664d, new GammaParticle(386700.0, 0.00321)), new(0.49444000000000005d, new GammaParticle(419830.0, 0.00295)), new(0.066802d, new GammaParticle(569300.0, 0.00218)), new(0.0891445152438048d, new GammaParticle(4749.0, 0.26107)), new(0.03149491702059708d, new GammaParticle(30625.0, 0.04048)), new(0.05818384818140972d, new GammaParticle(30973.0, 0.04003)), new(0.016998595526232476d, new GammaParticle(35089.0, 0.03533)), new(0.0211462528346332d, new GammaParticle(35414.0, 0.03501)), new(0.004147657308400724d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    