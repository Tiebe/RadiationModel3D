using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium139";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 138.95953d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium139() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium138() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    