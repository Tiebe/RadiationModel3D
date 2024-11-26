using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium109";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 108.9273d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.961d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin109() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.094d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin108() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 1.0d, new ProtonParticle() } } },
            { 0.039d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin105() }, { 1.0d, new AlphaParticle(4220002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    