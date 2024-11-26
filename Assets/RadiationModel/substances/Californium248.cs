using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium248";
        public override double halfLife { get; } = 28814400.0d;
        public override double atomicWeight { get; } = 248.07218d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999971d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium244() }, { 1.0d, new AlphaParticle(7383202.09) }, { 0.00018999999999999998d, new GammaParticle(42965.0, 0.02886) }, { 0.0002d, new GammaParticle(99383.0, 0.01248) }, { 0.079186068d, new GammaParticle(18579.0, 0.06673) } } },
            { 2.8999999999999997e-05d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    