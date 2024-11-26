using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium232";
        public override double halfLife { get; } = 2028.0d;
        public override double atomicWeight { get; } = 232.04118d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium232() }, { 0.317955442d, new GammaParticle(17136.0, 0.07235) }, { 0.17335190008611673d, new GammaParticle(97078.0, 0.01277) }, { 0.2759501752405551d, new GammaParticle(101068.0, 0.01227) }, { 0.1006249439533692d, new GammaParticle(114160.0, 0.01086) }, { 0.1352399246733282d, new GammaParticle(115608.0, 0.01072) }, { 0.034614980719959006d, new GammaParticle(117470.0, 0.01055) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium228() }, { 1.0d, new AlphaParticle(7738002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    