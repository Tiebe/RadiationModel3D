using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium68 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium68";
        public override double halfLife { get; } = 23408352.0d;
        public override double atomicWeight { get; } = 67.9281d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium68() }, { 0.0151654449d, new GammaParticle(1127.0, 1.10013) }, { 0.13254289646008263d, new GammaParticle(9225.0, 0.1344) }, { 0.2575648979014431d, new GammaParticle(9252.0, 0.13401) }, { 0.056499707394109644d, new GammaParticle(10306.0, 0.1203) }, { 0.0568387056384743d, new GammaParticle(10313.0, 0.12022) }, { 0.0003389982443646578d, new GammaParticle(10365.0, 0.11962) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    