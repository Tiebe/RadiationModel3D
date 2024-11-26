using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium93m";
        public override double halfLife { get; } = 508697646.71042d;
        public override double atomicWeight { get; } = 92.90641d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium93() }, { 5.91e-06d, new GammaParticle(30770.0, 0.04029) }, { 0.029125080997d, new GammaParticle(2299.0, 0.5393) }, { 0.03292296029449552d, new GammaParticle(16521.0, 0.07505) }, { 0.06287807542875386d, new GammaParticle(16615.0, 0.07462) }, { 0.016269515023261398d, new GammaParticle(18694.0, 0.06632) }, { 0.018709942276750605d, new GammaParticle(18795.0, 0.06597) }, { 0.0024404272534892094d, new GammaParticle(18951.0, 0.06542) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    