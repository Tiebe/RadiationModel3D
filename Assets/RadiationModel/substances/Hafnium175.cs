using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium175";
        public override double halfLife { get; } = 6048000.0d;
        public override double atomicWeight { get; } = 174.94151d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium175()), new(0.024024d, new GammaParticle(89360.0, 0.01387)), new(0.00294d, new GammaParticle(113810.0, 0.01089)), new(0.00022679999999999998d, new GammaParticle(161300.0, 0.00769)), new(0.0068292d, new GammaParticle(229600.0, 0.0054)), new(0.00168d, new GammaParticle(318900.0, 0.00389)), new(0.84d, new GammaParticle(343400.0, 0.00361)), new(0.0022848d, new GammaParticle(353300.0, 0.00351)), new(0.014363999999999998d, new GammaParticle(433000.0, 0.00286)), new(0.251d, new GammaParticle(8810.0, 0.14073)), new(0.265d, new GammaParticle(52965.0, 0.02341)), new(0.465d, new GammaParticle(54070.0, 0.02293)), new(0.153d, new GammaParticle(61387.0, 0.0202)), new(0.19399999999999998d, new GammaParticle(62084.0, 0.01997)), new(0.0404d, new GammaParticle(62927.0, 0.0197)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    