using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium83m";
        public override double halfLife { get; } = 171.0d;
        public override double atomicWeight { get; } = 82.92255d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium83()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.53d, new GammaParticle(259100.0, 0.00479)), new(0.191d, new GammaParticle(421800.0, 0.00294)), new(0.079d, new GammaParticle(494500.0, 0.00251)), new(1.148d, new GammaParticle(511000.0, 0.00243)), new(0.00299141152488d, new GammaParticle(1890.0, 0.656)), new(0.018431600383604054d, new GammaParticle(14098.0, 0.08794)), new(0.03541133599155438d, new GammaParticle(14165.0, 0.08753)), new(0.008743521083930596d, new GammaParticle(15898.0, 0.07799)), new(0.009880178824841572d, new GammaParticle(15955.0, 0.07771)), new(0.0011366577409109774d, new GammaParticle(16085.0, 0.07708)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium83()), new(0.0044d, new GammaParticle(62100.0, 0.01997)), new(0.01096185092d, new GammaParticle(2027.0, 0.61166)), new(0.04107413606964928d, new GammaParticle(14883.0, 0.08331)), new(0.07876152649980686d, new GammaParticle(14958.0, 0.08289)), new(0.019776043436330288d, new GammaParticle(16803.0, 0.07379)), new(0.022505137430543866d, new GammaParticle(16880.0, 0.07345)), new(0.00272909399421358d, new GammaParticle(17011.0, 0.07288)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    