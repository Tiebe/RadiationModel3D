using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony119 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony119";
        public override double halfLife { get; } = 137484.0d;
        public override double atomicWeight { get; } = 118.90394d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin119() }, { 0.165d, new GammaParticle(23870.0, 0.05194) }, { 0.117511556d, new GammaParticle(3753.0, 0.33036) }, { 0.20879953870172124d, new GammaParticle(25044.0, 0.04951) }, { 0.3907908266923474d, new GammaParticle(25271.0, 0.04906) }, { 0.11050094787462951d, new GammaParticle(28579.0, 0.04338) }, { 0.13226963460593152d, new GammaParticle(28810.0, 0.04304) }, { 0.02176868673130201d, new GammaParticle(29107.0, 0.0426) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    