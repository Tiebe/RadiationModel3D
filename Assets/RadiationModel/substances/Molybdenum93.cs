using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum93 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum93";
        public override double halfLife { get; } = 126227703898.368d;
        public override double atomicWeight { get; } = 92.90681d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium93() }, { 5.199999999999999e-06d, new GammaParticle(30770.0, 0.04029) }, { 0.060631910309999995d, new GammaParticle(2299.0, 0.5393) }, { 0.2111562309998751d, new GammaParticle(16521.0, 0.07505) }, { 0.40327775210060174d, new GammaParticle(16615.0, 0.07462) }, { 0.1043469190430636d, new GammaParticle(18694.0, 0.06632) }, { 0.11999895689952313d, new GammaParticle(18795.0, 0.06597) }, { 0.01565203785645954d, new GammaParticle(18951.0, 0.06542) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    