using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium71 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium71";
        public override double halfLife { get; } = 987552.0d;
        public override double atomicWeight { get; } = 70.92495d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium71() }, { 0.01523126958d, new GammaParticle(1127.0, 1.10013) }, { 0.13429071487494088d, new GammaParticle(9225.0, 0.1344) }, { 0.26096135809355003d, new GammaParticle(9252.0, 0.13401) }, { 0.057244758480625366d, new GammaParticle(10306.0, 0.1203) }, { 0.05758822703150912d, new GammaParticle(10313.0, 0.12022) }, { 0.0003434685508837522d, new GammaParticle(10365.0, 0.11962) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    