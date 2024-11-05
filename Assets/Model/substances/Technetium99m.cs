using System.Collections.Generic;

namespace RadiationModel.substances
{

    public class Technetium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium-99m";
        public override double halfLife { get; } = 6.0067 * TimeConstants.SECONDS_IN_HOUR;
        public override double atomicWeight { get; } = 98.9063;

        // TODO: find sources for decay products and probabilities
        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new ()
        {
            {0.88, new List<RadioactiveSubstance>() { new Technetium99(), new GammaParticle() } },
            {0.12, new List<RadioactiveSubstance>() { new Technetium99(1), new ElectronParticle() } }
        };


    }
}