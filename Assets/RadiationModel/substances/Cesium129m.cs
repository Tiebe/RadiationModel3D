using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium129m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 128.90668d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium129() }, { 2.3e-06d, new GammaParticle(6550.0, 0.18929) }, { 0.000789d, new GammaParticle(53200.0, 0.02331) }, { 0.008942d, new GammaParticle(129140.0, 0.0096) }, { 0.0012624d, new GammaParticle(135610.0, 0.00914) }, { 0.526d, new GammaParticle(149050.0, 0.00832) }, { 0.35768d, new GammaParticle(182320.0, 0.0068) }, { 0.06364600000000001d, new GammaParticle(237650.0, 0.00522) }, { 0.33664d, new GammaParticle(386700.0, 0.00321) }, { 0.49444000000000005d, new GammaParticle(419830.0, 0.00295) }, { 0.066802d, new GammaParticle(569300.0, 0.00218) }, { 0.0891445152438048d, new GammaParticle(4749.0, 0.26107) }, { 0.03149491702059708d, new GammaParticle(30625.0, 0.04048) }, { 0.05818384818140972d, new GammaParticle(30973.0, 0.04003) }, { 0.016998595526232476d, new GammaParticle(35089.0, 0.03533) }, { 0.0211462528346332d, new GammaParticle(35414.0, 0.03501) }, { 0.004147657308400724d, new GammaParticle(35818.0, 0.03462) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    