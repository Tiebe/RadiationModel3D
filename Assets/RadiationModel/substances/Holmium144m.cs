using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium144m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium144m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 143.95239d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium144() }, { 0.4004d, new GammaParticle(40200.0, 0.03084) }, { 0.44d, new GammaParticle(56400.0, 0.02198) }, { 0.0572d, new GammaParticle(59900.0, 0.0207) }, { 0.43560000000000004d, new GammaParticle(148100.0, 0.00837) }, { 0.1804d, new GammaParticle(208900.0, 0.00594) }, { 0.198267911952d, new GammaParticle(7656.0, 0.16194) }, { 0.1580580147329827d, new GammaParticle(46700.0, 0.02655) }, { 0.28149245722703947d, new GammaParticle(47547.0, 0.02608) }, { 0.0909450857460141d, new GammaParticle(53982.0, 0.02297) }, { 0.11459080803997779d, new GammaParticle(54577.0, 0.02272) }, { 0.023645722293963667d, new GammaParticle(55293.0, 0.02242) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    