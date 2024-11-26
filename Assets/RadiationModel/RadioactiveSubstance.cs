using System.Collections.Generic;

namespace RadiationModel
{

    /**
     * This class represents a radioactive substance
     *
     * <seealso href="https://en.wikipedia.org/wiki/Radionuclide"/>
     */
    public abstract class RadioactiveSubstance
    {
        /**
         * User-friendly name of the substance
         */
        public abstract string name { get; }

        /**
         * The half life of the substance in seconds
         */
        public abstract double halfLife { get; }

        /**
         * The atomic weight of the substance in atomic mass units
         */
        public abstract double atomicWeight { get; }

        /**
         * The charge of the substance in elementary charge units
         */
        public int charge { get; protected set; } = 0;


        /**
         * The decay products of the substance.
         * Key: the probability of decaying into this product
         * Value: the list of substances that the substance decays into
         */
        public abstract Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; }
    }
}