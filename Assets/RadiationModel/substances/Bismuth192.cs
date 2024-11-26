using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth192 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth192";
        public override double halfLife { get; } = 34.6d;
        public override double atomicWeight { get; } = 191.98547d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium192() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium188() }, { 1.0d, new AlphaParticle(7403002.09) }, { 0.11d, new GammaParticle(184600.0, 0.00672) }, { 0.003008162476d, new GammaParticle(12148.0, 0.10206) }, { 0.0023268173947629473d, new GammaParticle(70832.0, 0.0175) }, { 0.0039277808824492695d, new GammaParticle(72874.0, 0.01701) }, { 0.0013357931555804043d, new GammaParticle(82629.0, 0.015) }, { 0.001732523722787784d, new GammaParticle(83631.0, 0.01483) }, { 0.00039673056720738d, new GammaParticle(84866.0, 0.01461) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    