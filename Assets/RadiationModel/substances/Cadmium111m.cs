using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium111m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium111m";
        public override double halfLife { get; } = 2910.0d;
        public override double atomicWeight { get; } = 110.90461d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium111()), new(0.2914d, new GammaParticle(150825.0, 0.00822)), new(0.94d, new GammaParticle(245395.0, 0.00505)), new(0.047621423095999996d, new GammaParticle(3388.0, 0.36595)), new(0.1382666159075201d, new GammaParticle(22983.0, 0.05395)), new(0.2600462966099682d, new GammaParticle(23173.0, 0.0535)), new(0.07248486250635511d, new GammaParticle(26184.0, 0.04735)), new(0.08567710748251173d, new GammaParticle(26381.0, 0.047)), new(0.013192244976156628d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    