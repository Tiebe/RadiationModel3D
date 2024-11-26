using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium187";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 187.00303d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead183() }, { 1.0d, new AlphaParticle(8997002.09) }, { 0.6729999999999999d, new GammaParticle(286000.0, 0.00434) }, { 0.099387823d, new GammaParticle(12522.0, 0.09901) }, { 0.0749934411925461d, new GammaParticle(72805.0, 0.01703) }, { 0.12603939696226235d, new GammaParticle(74970.0, 0.01654) }, { 0.04307846531888753d, new GammaParticle(84986.0, 0.01459) }, { 0.05608816184519157d, new GammaParticle(86022.0, 0.01441) }, { 0.013009696526304033d, new GammaParticle(87301.0, 0.0142) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    