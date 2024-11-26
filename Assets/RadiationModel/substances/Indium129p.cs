using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium129p : RadioactiveSubstance
    {
        public override string name { get; } = "Indium129p";
        public override double halfLife { get; } = 0.67d;
        public override double atomicWeight { get; } = 128.92359d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin129()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.014499999999999999d, new GammaParticle(41000.0, 0.03024)), new(0.41759999999999997d, new GammaParticle(382490.0, 0.00324)), new(0.12354d, new GammaParticle(473990.0, 0.00262)), new(0.036539999999999996d, new GammaParticle(515100.0, 0.00241)), new(0.5336d, new GammaParticle(570410.0, 0.00217)), new(0.58d, new GammaParticle(1136310.0, 0.00109)), new(0.4292d, new GammaParticle(1324250.0, 0.00094)), new(0.07888d, new GammaParticle(1716100.0, 0.00072)), new(0.4814d, new GammaParticle(2189920.0, 0.00057)), new(0.1972d, new GammaParticle(2230880.0, 0.00056)), new(0.036310062479999995d, new GammaParticle(3753.0, 0.33036)), new(0.04852687751401459d, new GammaParticle(25044.0, 0.04951)), new(0.09082327814713567d, new GammaParticle(25271.0, 0.04906)), new(0.02568140713354198d, new GammaParticle(28579.0, 0.04338)), new(0.03074064433884975d, new GammaParticle(28810.0, 0.04304)), new(0.00505923720530777d, new GammaParticle(29107.0, 0.0426)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    