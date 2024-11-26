using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium87m";
        public override double halfLife { get; } = 10134.0d;
        public override double atomicWeight { get; } = 86.90929d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium87() }, { 0.8219d, new GammaParticle(388531.0, 0.00319) }, { 0.00477230858412d, new GammaParticle(1890.0, 0.656) }, { 0.029286504102237734d, new GammaParticle(14098.0, 0.08794) }, { 0.05626609817913109d, new GammaParticle(14165.0, 0.08753) }, { 0.013892834087284232d, new GammaParticle(15898.0, 0.07799) }, { 0.01569890251863118d, new GammaParticle(15955.0, 0.07771) }, { 0.0018060684313469502d, new GammaParticle(16085.0, 0.07708) } } },
            { 0.003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium87() }, { 7.662180375e-05d, new GammaParticle(1767.0, 0.70166) }, { 0.0004952511873972259d, new GammaParticle(13336.0, 0.09297) }, { 0.0009533227861351798d, new GammaParticle(13396.0, 0.09255) }, { 0.0002320833570498155d, new GammaParticle(15021.0, 0.08254) }, { 0.0002590050264675941d, new GammaParticle(15070.0, 0.08227) }, { 2.69216694177786e-05d, new GammaParticle(15187.0, 0.08164) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    